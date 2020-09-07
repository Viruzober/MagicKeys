@echo off

setlocal enableextensions enabledelayedexpansion
set gtkeyword=T._

if "%~1" == "--help" (
echo The universal NGettext integration script by A11CF0
echo Usage: %0 [ROOTDIR] [TARGETDIR]
echo %0 --help
echo --help displays this help end exits.
echo ROOTDIR specifies the root directory of the solution in which the 'Locale' folder must be present.
echo TARGETDIR Specifies the directory to which compiled *.mo files should be copied.
echo If ROOTDIR is omitted '..' relative to the path of the script is used.
echo If TARGETDIR is omitted the *.mo files will not be copied.
exit /b
)

if not "%~1" == "" (
set rootdir=%~1
set localedir=!rootdir!\Locale
) else (
set rootdir=%~dp0\..
set localedir=!rootdir!\Locale
)
if not "%~2" == "" set destdir=%~2\Locale

 if not exist "%localedir%" (
echo No locales to process.
exit /b 1
)

set gtdir=%userprofile%\.nuget\packages\gettext.tools
if defined programfiles(x86) set pogtdir=%programfiles(x86)%\Poedit\GettextTools
if not defined pogtdir set pogtdir=%programfiles%\Poedit\GettextTools

for /r "%gtdir%" %%i in (.) do if exist "%%i\msgfmt.exe" set gtbindir="%%i"
if not defined gtbindir if exist "%pogtdir%\bin\msgfmt.exe" set gtbindir=!pogtdir!\bin
if not defined gtbindir (
echo Gettext tools not found.
exit /b 1
)

set filelist=Files.txt
for /r "%localedir%" %%i in (*.po) do if not defined projname set projname=%%~ni
for /r "%rootdir%" %%i in (*.cs) do echo %%i >> %filelist%
"%gtbindir%\xgettext" --force-po --add-comments --from-code=UTF-8 --language=C# --keyword=%gtkeyword% --package-name=%projname% -o "%localedir%\%projname%.pot" -f %filelist%
set err=%errorlevel%
if exist %filelist% del %filelist%
if %err% neq 0 exit /b %err%

for /r "%localedir%" %%i in (*.po) do (
set file=%%i
"!gtbindir!\msgmerge" --update "!file!" "!localedir!\!projname!.pot" || exit /b
"!gtbindir!\msgfmt" -c "!file!" -o "!file:.po=.mo!" || exit /b
)

if not defined destdir exit /b
set excl=Exclude.txt
echo .po > %excl%
xcopy /e /i /q /y /exclude:%excl% "%localedir%" "%destdir%"
set err=%errorlevel%
del %excl%
exit /b %err%

endlocal
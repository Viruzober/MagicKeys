@echo off

setlocal enableextensions enabledelayedexpansion
set gtkeyword=T._

pushd "%~dp0\.."
if "%~1" == "--help" (
echo The universal NGettext integration script by A11CF0
echo Usage: %0 [ROOTDIR] [TARGETDIR]
echo %0 --help
echo --help displays this help end exits.
echo ROOTDIR specifies the root directory of the solution in which the 'Locale' folder must be present.
echo TARGETDIR Specifies the directory to which compiled *.mo files should be copied.
echo If ROOTDIR is omitted '..' relative to the path of the script is used.
echo If TARGETDIR is omitted the *.mo files will not be copied.
call :exit && goto :eof
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
echo No locales to process >&2
call :exit 1 && goto :eof
)

set gtdir=%userprofile%\.nuget\packages\gettext.tools
if defined programfiles(x86) set pogtdir=%programfiles(x86)%\Poedit\GettextTools
if not defined pogtdir set pogtdir=%programfiles%\Poedit\GettextTools

for /r "%gtdir%" %%I in (.) do if exist "%%I\msgfmt.exe" set gtbindir="%%I"
if not defined gtbindir if exist "%pogtdir%\bin\msgfmt.exe" set gtbindir=!pogtdir!\bin
if not defined gtbindir (
echo Gettext tools not found >&2
call :exit 1 && goto :eof
)

set filelist=Files.txt
for /r "%localedir%" %%D in (*.po) do if not defined projname set projname=%%~nxD
for /r "%rootdir%" %%F in (*.cs) do (
set p=%%F
echo !p:%__cd__%=!>> "%filelist%"
)

"%gtbindir%\xgettext" --force-po --add-comments --from-code=UTF-8 --language=C# --keyword=%gtkeyword% --package-name=%projname% -o "%localedir%\%projname%.pot" -f "%filelist%"
set err=%errorlevel%
if exist "%filelist%" del "%filelist%"
if %err% neq 0 call :exit %err% && goto :eof

for /r "%localedir%" %%F in (*.po) do (
set file=%%F
"!gtbindir!\msgmerge" --update "!file!" "!localedir!\!projname!.pot" || call :exit && goto :eof
"!gtbindir!\msgfmt" -c "!file!" -o "!file:.po=.mo!" || call :exit && goto :eof
)

if not defined destdir call :exit && goto :eof

set excl=Exclude.txt
echo .po > "%excl%"
xcopy /e /i /q /y /exclude:%excl% "%localedir%" "%destdir%"
set err=%errorlevel%
del %excl%
call :exit %err% && goto :eof

:exit
set err=%errorlevel%
popd
if not "%~1" == "" (
exit /b %~1
) else (
exit /b %err%
)

endlocal
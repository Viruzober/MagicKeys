@echo off

setlocal enableextensions enabledelayedexpansion
set projname=MagicKeys

if not "%~1" == "" (
set rootdir=%~1
set localedir=!rootdir!\Locale
) else (
set rootdir=..
set localedir=!rootdir!\Locale
)
if not "%~2" == "" set destdir=%~2\Locale

 if not exist %localedir% (
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
for /r "%rootdir%" %%i in (*.cs) do echo %%i >> %filelist%
"%gtbindir%\xgettext" --force-po --add-comments --from-code=UTF-8 --language=C# --keyword=T._ --package-name=%projname% -o "%localedir%\%projname%.pot" -f %filelist% && del %filelist%
if errorlevel 1 exit /b 1

for /r "%localedir%" %%i in (*.po) do (
set file=%%i
"!gtbindir!\msgmerge" --update "!file!" "!localedir!\!projname!.pot" || exit /b 1
"!gtbindir!\msgfmt" -c "!file!" -o "!file:.po=.mo!" || exit /b 1
)

if not defined destdir exit /b
set excl=Exclude.txt
echo .po > %excl%
xcopy /e /i /q /y /exclude:%excl% "%localedir%" "%destdir%"
del %excl%

endlocal
@echo off

setlocal enableextensions enabledelayedexpansion

if "%1" == "" exit /b 1
if "%2" == "" exit /b 1

set gtdir=%userprofile%\.nuget\packages\gettext.tools
for /r "%gtdir%" %%i in (msgfmt.exe) do if exist %%i set msgfmt="%%i"
if "%msgfmt%" == "" (
echo msgfmt not found
exit /b 1
)

for /r "%1" %%i in (*.po) do (
set file=%%i
"!msgfmt!" -c "!file!" -o "!file:.po=.mo!" || exit /b 1
)

set excl=Exclude.txt
echo .po > %excl%
xcopy /e /i /q /y /exclude:%excl% %1 %2
del %excl%

endlocal
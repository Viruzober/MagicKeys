@echo off

setlocal enableextensions enabledelayedexpansion

pushd "%~dp0.."
set distdir=Dist
if not exist "%distdir%" (
echo Error: Nothing to pack 1>&2
call :exit 1
goto :eof
)

set packagedir=%distdir%\Packages
for %%D in ("%cd%\.") do set name=%%~nxD
for /f "useback" %%V in (`call "%~dp0GetVersion.cmd"`) do set version=%%V
if not "%version%" == "" (
set package=%name%_%version%
) else (
set package=%name%
)

echo Packing %package%...
if not exist "%packagedir%" mkdir "%packagedir%"
for /f "usebackq" %%D in (`dir /b /a:d "%distdir%"`) do powershell Compress-Archive -Force "%distdir%\%%D\*" "%packagedir%\%package%_%%D.zip"
for /f "delims=_ tokens=2" %%V in ("%version%") do echo %%V> "%packagedir%\Version.txt"
echo Done
call :exit
goto :eof

:exit
popd
exit /b %~1

endlocal
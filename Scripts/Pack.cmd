@echo off

setlocal enableextensions enabledelayedexpansion

pushd "%~dp0.."
for %%D in ("%cd%\.") do set name=%%~nxD
for /f "useback" %%V in (`call "%~dp0GetVersion.cmd"`) do set version=%%V
if not "%version%" == "" (
set package=%name%_%version%
) else (
set package=%name%
)

set distdir=Dist
set packagedir=%distdir%\Packages

echo Packing %package%...
if not exist "%packagedir%" mkdir "%packagedir%"
for /f "usebackq" %%D in (`dir /b /a:d %distdir%`) do powershell Compress-Archive -Force "%distdir%\%%D\*" "%packagedir%\%package%_%%D.zip"
echo Done
popd
endlocal
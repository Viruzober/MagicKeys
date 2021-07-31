@echo off

setlocal enableextensions enabledelayedexpansion

pushd "%~dp0.."
set distdir=Dist
if not exist "%distdir%" (
echo Error: Nothing to pack 1>&2
call :exit 1
goto :eof
)

set packagedir=Packages
for %%D in ("%cd%\.") do set name=%%~nxD
for /f "useback" %%V in (`call "%~dp0GetVersion.cmd"`) do set version=%%V
if not "%version%" == "" (
set package=%name%_%version%
) else (
set package=%name%
)

echo Packing %package%...
if not exist "%distdir%\%packagedir%" mkdir "%distdir%\%packagedir%"
for /f "usebackq" %%D in (`dir /b /a:d "%distdir%"`) do (
if not "%%D" == "%packagedir%" (
powershell Compress-Archive -Force "%distdir%\%%D\*" "%distdir%\%packagedir%\%package%_%%D.zip"
)
)
echo Generating checksums...
for %%P in ("%distdir%\%packagedir%\*.zip") do certutil -hashfile %%P SHA256 | findstr /v ":"> "%%P.sum"
echo Creating version manifest...
for /f "delims=_ tokens=2" %%V in ("%version%") do echo %%V> "%distdir%\%packagedir%\Version.txt"
echo Done
call :exit && goto :eof

:exit
set err=%errorlevel%
popd
if not "%~1" == "" (
exit /b %~1
) else (
exit /b %err%
)

endlocal
@echo off

setlocal enableextensions enabledelayedexpansion

pushd "%~dp0.."
for %%D in ("%cd%\.") do set projname=%%~nxD
set distdir=Dist

echo Packing...
for /f "usebackq" %%D in (`dir /b /a:d %distdir%`) do powershell Compress-Archive -Force "%distdir%\%%D\*" "%distdir%\%projname%_%%D.zip"
echo Done
popd
endlocal
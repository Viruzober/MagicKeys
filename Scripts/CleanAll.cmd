@echo off

pushd "%~dp0\.."
dotnet clean -c Release -p:Platform=x64
if not errorlevel 1 dotnet clean -c Release -p:Platform=x86
popd
pause
@echo off

pushd "%~dp0\.."
dotnet clean -c Release -p:Platform=x64
if not errorlevel 1 dotnet clean -c Release -p:Platform=x86
if exist Dist rd /s /q Dist
popd
if /i not "%~1" == "/ni" pause
@echo off

pushd "%~dp0\.."
dotnet publish -p:PublishProfile=x64 -c Release -p:Platform=x64
if not errorlevel 1 dotnet publish -p:PublishProfile=x86 -c Release -p:Platform=x86
popd
if /i not "%~1" == "/ni" pause
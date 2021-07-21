@echo off

setlocal enableextensions enabledelayedexpansion

pushd "%~dp0\.."
set distdir=Dist
dotnet clean -c Debug -p:Platform=x64
if not errorlevel 1 dotnet clean -c Debug -p:Platform=x86
if not errorlevel 1 dotnet clean -c Release -p:Platform=x64
if not errorlevel 1 dotnet clean -c Release -p:Platform=x86
if exist %distdir% rd /s /q %distdir%
popd
if /i not "%~1" == "/ni" pause
endlocal
@echo off

setlocal enableextensions enabledelayedexpansion

set configuration=%~1
set platform=%~2
if "%configuration%" == "" set configuration=Debug
if "%platform%" == "" set platform=x64

pushd "%~dp0.."
dotnet publish -p:PublishProfile=%platform% -c %configuration% -p:Platform=%platform%
popd
endlocal
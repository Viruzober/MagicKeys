@echo off

setlocal enableextensions enabledelayedexpansion

pushd "%~dp0.."
call %~dp0Build.cmd Release x64
if not errorlevel 1 call %~dp0Build.cmd Release x86
if not errorlevel 1 call %~dp0Pack.cmd
popd
if /i not "%~1" == "/ni" pause
endlocal
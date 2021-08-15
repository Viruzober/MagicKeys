@echo off

setlocal enableextensions enabledelayedexpansion

pushd "%~dp0.."
set distdir=Dist
if exist "%distdir%" call "%~dp0CleanAll.cmd" /ni
if not errorlevel 1 call "%~dp0Build.cmd" Release x64
if not errorlevel 1 call "%~dp0Build.cmd" Release x86
if not errorlevel 1 call "%~dp0Pack.cmd"
set err=%errorlevel%

popd
if /i not "%~1" == "/ni" pause
exit /b %err%

endlocal
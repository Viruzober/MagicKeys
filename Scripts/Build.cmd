@echo off

setlocal enableextensions enabledelayedexpansion

set configuration=%~1
set platform=%~2
if "%configuration%" == "" set configuration=Debug
if "%platform%" == "" set platform=x64

pushd "%~dp0.."
set distdir=Dist\%platform%

call "%~dp0CompileLocales.cmd" "%cd%" "%distdir%" > nul 2>&1
dotnet publish -p:PublishProfile=%platform% -c %configuration% -p:Platform=%platform% || call :exit && goto :eof
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
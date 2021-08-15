@echo off

setlocal enableextensions enabledelayedexpansion

set configuration=%~1
set platform=%~2
if "%configuration%" == "" set configuration=Debug
if "%platform%" == "" set platform=x64

pushd "%~dp0.."
set distdir=Dist
for %%N in (*.sln) do if not defined projname set projname=%%~nN

dotnet publish -p:PublishProfile=%platform% -c %configuration% -p:Platform=%platform% "%projname%.sln" || call :exit && goto :eof

for /f "usebackq" %%P in (`dir /b /a:d`) do if exist "%%P\%%P.csproj" (
if not exist "%distdir%\%platform%\%%P.exe" (
dotnet publish -p:PublishProfile=%platform% -c %configuration% -p:Platform=%platform% "%%P\%%P.csproj"
)
)
dotnet publish --no-restore --no-build -p:PublishProfile=%platform% -c %configuration% -p:Platform=%platform% "%projname%\%projname%.csproj" || call :exit && goto :eof
del "%distdir%\%platform%\*.runtimeconfig.json" > nul
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
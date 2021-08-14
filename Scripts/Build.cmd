@echo off

setlocal enableextensions enabledelayedexpansion

set configuration=%~1
set platform=%~2
if "%configuration%" == "" set configuration=Debug
if "%platform%" == "" set platform=x64

pushd "%~dp0.."
for %%N in (*.sln) do if not defined projname set projname=%%~nN
for /f "usebackq" %%D in (`dir /b /a:d`) do if exist "%%D\%%D.csproj" (
if not "%%D" == "%projname%" dotnet publish -p:PublishProfile=%platform% -c %configuration% -p:Platform=%platform% "%%D\%%D.csproj"
)

dotnet publish -p:PublishProfile=%platform% -c %configuration% -p:Platform=%platform% "%projname%\%projname%.csproj"
popd
endlocal
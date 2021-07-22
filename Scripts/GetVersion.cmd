@echo off

setlocal enableextensions enabledelayedexpansion

git status > nul 2>&1 || exit /b
for /f "usebackq" %%H in (`git rev-parse --short HEAD`) do set hash=%%H
(
for /f "usebackq" %%V in (`git describe --exact-match --tags %hash%`) do set version=%%V
) > nul 2>&1
if not "%version%" == "" (
set version=Release_%version%
) else (
set version=Nightly_%hash%
)

echo %version%
endlocal
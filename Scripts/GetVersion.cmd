@echo off

setlocal enableextensions enabledelayedexpansion

git status > nul 2>&1 || exit /b
for /f "usebackq" %%B in (`git branch --show-current`) do set branch=%%B
if "%branch%" == "" set branch=unknown
for /f "usebackq" %%H in (`git rev-parse --short HEAD`) do set hash=%%H
(
for /f "usebackq" %%V in (`git describe --exact-match --tags %hash%`) do set version=%%V
) > nul 2>&1
if "%version%" == "" set version=%branch%_%hash%
echo %version%
endlocal
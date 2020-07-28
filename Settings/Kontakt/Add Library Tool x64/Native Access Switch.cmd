@echo off
title Native Access Switch
reg Add "HKEY_CURRENT_USER\Software\Native Instruments\ALSupport" /v "ExecutablePath" /d "%PROGRAMFILES%\Native Instruments\Native Access\Native Access.exe" /F >Nul
cls

@echo off
title Add Library Installer
color 05
mode con: cols=35 lines=11
reg Add "HKEY_CURRENT_USER\Software\Native Instruments\ALSupport" /v "ExecutablePath" /d "%COMMONPROGRAMFILES%\Native Instruments\Kontakt\Add Library.exe" /F >Nul
cls
echo. && echo      -------------------------
echo      / Add Library Installer /
echo      -------------------------
echo. && echo        Done!
echo. && echo        Hit any key to exit!
echo. && echo      -------------------------
pause >nul
del "%COMMONPROGRAMFILES%\Native Instruments\Kontakt\Add Library.cmd"
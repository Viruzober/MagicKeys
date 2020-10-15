@echo off

pushd "%~dp0\.."
dotnet publish -p:PublishProfile=x64 -p:Configuration=Release -p:Platform=x64 && ^
dotnet publish -p:PublishProfile=x86 -p:Configuration=Release -p:Platform=x86
popd
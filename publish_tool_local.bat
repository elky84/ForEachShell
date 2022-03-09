dotnet pack .  -c Release -o ../DotnetPack

dotnet tool uninstall -g ForEachShell  

dotnet tool install -g ForEachShell --add-source ../DotnetPack

pause
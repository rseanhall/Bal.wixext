appveyor AddMessage install6sdk
appveyor DownloadFile https://dotnetcli.azureedge.net/dotnet/Sdk/6.0.100-alpha.1.21059.3/dotnet-sdk-6.0.100-alpha.1.21059.3-win-x64.exe -FileName dotnet-6-sdk-win-x64.exe
dotnet-6-sdk-win-x64.exe /install /quiet

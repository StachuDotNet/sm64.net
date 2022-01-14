FROM mcr.microsoft.com/dotnet/runtime:6.0

COPY SM64.Net.TwitchBot/bin/Release/net6.0/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "SM64.Net.TwitchBot.dll"]
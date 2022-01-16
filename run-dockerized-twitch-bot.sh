dotnet build
dotnet publish -c Release
docker rmi sm64-twitch-bot-image
docker build -t sm64-twitch-bot-image -f Dockerfile-twitch-bot .
docker run -it --rm -e SM64DOTNET_TWITCH_OAUTH_TOKEN sm64-twitch-bot-image 
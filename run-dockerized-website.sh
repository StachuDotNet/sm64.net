dotnet build
dotnet publish -c Release
docker rmi sm64-website-image
docker build -t sm64-website-image -f Dockerfile-website .
echo 'about to expose site on http://localhost:8080'
docker run -it --rm -p 8080:80 sm64-website-image
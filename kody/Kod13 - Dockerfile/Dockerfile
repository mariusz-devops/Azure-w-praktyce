FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
# Kopiujemy opublikowaną aplikację
COPY ./publish .
# Nasłuchujemy na porcie kontenera
EXPOSE 80
ENTRYPOINT ["dotnet", "Backend.dll"]
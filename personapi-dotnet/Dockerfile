# Usa la imagen oficial de .NET 8 SDK para construir el proyecto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copia el archivo .csproj y restaura las dependencias
COPY . ./personapi-dotnet/
WORKDIR /app/personapi-dotnet
RUN dotnet restore

# Copia el resto del contenido del proyecto y publica la aplicación
COPY . .
# Añadir el paquete Swashbuckle.AspNetCore
RUN dotnet add package Swashbuckle.AspNetCore

# Restaurar dependencias
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Usa una imagen ligera de .NET 8 para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/personapi-dotnet/out .

# Expone el puerto en el que la aplicación correrá
EXPOSE 80
EXPOSE 443

# Define el comando que se ejecutará cuando el contenedor inicie
ENTRYPOINT ["dotnet", "personapi-dotnet.dll"]


#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["FoodFinder/FoodFinder.csproj", "FoodFinder/"]
RUN dotnet restore "FoodFinder/FoodFinder.csproj"
COPY . .
WORKDIR "/src/FoodFinder"
RUN dotnet build "FoodFinder.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FoodFinder.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FoodFinder.dll"]
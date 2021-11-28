#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Levin.Rate/Levin.Rate.csproj", "Levin.Rate/"]
RUN dotnet restore "Levin.Rate/Levin.Rate.csproj"
COPY . .
WORKDIR "/src/Levin.Rate"
RUN dotnet build "Levin.Rate.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Levin.Rate.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Levin.Rate.dll"]
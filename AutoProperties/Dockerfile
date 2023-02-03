FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["AutoProperties/AutoProperties.csproj", "AutoProperties/"]
RUN dotnet restore "AutoProperties/AutoProperties.csproj"
COPY . .
WORKDIR "/src/AutoProperties"
RUN dotnet build "AutoProperties.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AutoProperties.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AutoProperties.dll"]

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Encoding/Encoding.csproj", "Encoding/"]
RUN dotnet restore "Encoding/Encoding.csproj"
COPY . .
WORKDIR "/src/Encoding"
RUN dotnet build "Encoding.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Encoding.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Encoding.dll"]

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Partial_Methods/Partial_Methods.csproj", "Partial_Methods/"]
RUN dotnet restore "Partial_Methods/Partial_Methods.csproj"
COPY . .
WORKDIR "/src/Partial_Methods"
RUN dotnet build "Partial_Methods.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Partial_Methods.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Partial_Methods.dll"]

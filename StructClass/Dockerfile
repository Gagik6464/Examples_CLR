FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["StructClass/StructClass.csproj", "StructClass/"]
RUN dotnet restore "StructClass/StructClass.csproj"
COPY . .
WORKDIR "/src/StructClass"
RUN dotnet build "StructClass.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "StructClass.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StructClass.dll"]

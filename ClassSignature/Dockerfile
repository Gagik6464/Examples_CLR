FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ClassSignature/ClassSignature.csproj", "ClassSignature/"]
RUN dotnet restore "ClassSignature/ClassSignature.csproj"
COPY . .
WORKDIR "/src/ClassSignature"
RUN dotnet build "ClassSignature.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ClassSignature.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClassSignature.dll"]

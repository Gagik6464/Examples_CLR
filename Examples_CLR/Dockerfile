FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Test_Examples_CLR/Test_Examples_CLR.csproj", "Test_Examples_CLR/"]
RUN dotnet restore "Test_Examples_CLR/Test_Examples_CLR.csproj"
COPY . .
WORKDIR "/src/Test_Examples_CLR"
RUN dotnet build "Test_Examples_CLR.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Test_Examples_CLR.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Test_Examples_CLR.dll"]

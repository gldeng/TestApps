FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM --platform=linux/amd64 mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["TestBn254/TestBn254.csproj", "TestBn254/"]
RUN dotnet restore "TestBn254/TestBn254.csproj"
COPY . .
WORKDIR "/src/TestBn254"
RUN dotnet build "TestBn254.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM --platform=linux/amd64 build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "TestBn254.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM --platform=linux/amd64 base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestBn254.dll"]

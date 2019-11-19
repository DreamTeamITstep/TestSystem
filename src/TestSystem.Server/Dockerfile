FROM mcr.microsoft.com/dotnet/core/sdk AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./TestSystem.Server/*.csproj ./TestSystem.Server/
WORKDIR /app/TestSystem.Server
RUN dotnet restore

# Copy everything else and build
WORKDIR /app
COPY ./TestSystem.Server ./TestSystem.Server
COPY ./TestSystem.Common ./TestSystem.Common

WORKDIR /app/TestSystem.Server
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/sdk
WORKDIR /app/TestSystem.Server
COPY --from=build-env /app/TestSystem.Server/out .
ENTRYPOINT ["dotnet", "TestSystem.Server.dll"]
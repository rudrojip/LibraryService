# Set base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env

# Set working directory
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build the app
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /app
COPY --from=build-env /app/out .

# Set entrypoint
ENTRYPOINT ["dotnet", "NotificationService.dll"]
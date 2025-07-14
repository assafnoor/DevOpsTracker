# ------------------------
# Base runtime image
# ------------------------
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base

RUN adduser --disabled-password --gecos "" appuser && \
    mkdir -p /app/logs && \
    chown -R appuser:appuser /app && \
    chmod 750 /app/logs

RUN apt-get update && apt-get install -y curl && rm -rf /var/lib/apt/lists/*

USER appuser
WORKDIR /app

EXPOSE 8080
EXPOSE 8081

ENV DOTNET_RUNNING_IN_CONTAINER=true

HEALTHCHECK --interval=30s --timeout=10s --start-period=20s --retries=3 \
    CMD curl --fail --silent --show-error http://localhost:8080/health || exit 1

# ------------------------
# Build stage
# ------------------------
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["Identity.API/Identity.API.csproj", "Identity.API/"]
COPY ["Identity.Application/Identity.Application.csproj", "Identity.Application/"]
COPY ["Identity.Contracts/Identity.Contracts.csproj", "Identity.Contracts/"]
COPY ["Identity.Domain/Identity.Domain.csproj", "Identity.Domain/"]
COPY ["Identity.Infrastructure/Identity.Infrastructure.csproj", "Identity.Infrastructure/"]
RUN dotnet restore "Identity.API/Identity.API.csproj"

COPY . .

WORKDIR /src/Identity.API
RUN dotnet build "Identity.API.csproj" -c $BUILD_CONFIGURATION -o /app/build


# ------------------------
# Publish stage
# ------------------------
FROM build AS publish

ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Identity.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# ------------------------
# Final runtime image
# ------------------------
FROM base AS final

WORKDIR /app
COPY --from=publish /app/publish .

ARG ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_ENVIRONMENT=$ASPNETCORE_ENVIRONMENT

ENTRYPOINT ["dotnet", "Identity.API.dll"]

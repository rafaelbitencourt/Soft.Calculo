# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY Soft.CalculoJuros.API/*.csproj Soft.CalculoJuros.API/
COPY Soft.CalculoJuros.Aplicacao/*.csproj Soft.CalculoJuros.Aplicacao/
COPY Soft.CalculoJuros.Dominio/*.csproj Soft.CalculoJuros.Dominio/
COPY Soft.CalculoJuros.Infra/*.csproj Soft.CalculoJuros.Infra/
RUN dotnet restore Soft.CalculoJuros.API/Soft.CalculoJuros.API.csproj

# copy and build app and libraries
COPY Soft.CalculoJuros.API/ Soft.CalculoJuros.API/
COPY Soft.CalculoJuros.Aplicacao/ Soft.CalculoJuros.Aplicacao/
COPY Soft.CalculoJuros.Dominio/ Soft.CalculoJuros.Dominio/
COPY Soft.CalculoJuros.Infra/ Soft.CalculoJuros.Infra/
WORKDIR /source/Soft.CalculoJuros.API
RUN dotnet build -c release --no-restore

# test stage -- exposes optional entrypoint
# target entrypoint with: docker build --target test
FROM build AS test
WORKDIR /source/tests
COPY Soft.CalculoJuros.Tests/ .
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

FROM build AS publish
RUN dotnet publish -c release --no-build -o /app

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Soft.CalculoJuros.API.dll"]
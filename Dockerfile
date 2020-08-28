FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

COPY . ./
RUN dotnet restore
RUN dotnet publish -c Release -o out

# Copy the development database
# (this should be replaced with a seperate container for sqlite or host volume)
COPY src/Server/database.db ./out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /App

COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "Server.dll"]
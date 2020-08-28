## Developer setup
1. Ef tool to work with database design: `dotnet tool install --global dotnet-ef`
1. To create database: `dotnet ef database update -s ./src/server`

### Docker setup for development

*PS: As of currently, a database must exist in ./src/server/database.db for this project to work with docker*

*Since this is just sample application, that will work fine for demonstration purposes*

> Replace `password` with a password
1. Create a ssl certificate:
   - `dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\BlazorDocs.pfx -p password`
1. Add certificate password as dotnet secret:
   - `dotnet user-secrets set "Kestrel:Certificates:Development:Password" "password" -p ./src/server`
1. Run with:
   - `docker-compose up --build`


donet watch run
dotnet tool install --global dotnet-ef --version 8.*

dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

dotnet build

dotnet ef migrations add init
dotnet ef database update
dotnet ef migrations list


# install
# Newtonsoft.Json
# Microsoft.AspNetCore.Mvc.NewtonsoftJson


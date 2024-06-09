# helpers extensions + download

1) Extensions vscode
c# from microsoft
c# extensions from josKreativ

2) Download from
[.net](https://dotnet.microsoft.com/pt-br/)

3) Helper commands

a) To install packages

```
dotnet add package <package_name>
```

b) List of helper commands

```
dotnet new list
```

# Criar API

```
dotnet --version #8.0.301 
```

Web API: An ASP.NET Core web API project. (api)

```
dotnet new webapi  
```

tem um que é

```
dotnet new mvc 
```

get aplication packages

```
dotnet restore
```

run application

```
dotnet run
```

se der erro

create a Nuget.config file vscode problem
 `put this in the Nuget.config file do not eat it`

```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
      <clear /> <!-- (optional) this is for clear sources like default Offline repo -->
      <add key="nuget.org" value="https://api.nuget.org/v3/index.json" protocolVersion="3" />
  </packageSources>
</configuration>
```

To run on watch mode

```
dotnet tool install -g dotnet-watch
dotnet watch run
```

go to

```
http://localhost:5151/swagger
```

# Criar controller

dotnet new mvccontroller -o SomeController

# if you put this in the controller it registers as a route also

```
using Microsoft.AspNetCore.Mvc;
namespace MyApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "This is the Teste endpoint!" });
        }
    }
}
```

change the Program.cs make it

```
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add services for controllers
builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use routing and map controllers
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers();
});

app.Run();

```

# Set database TODO: ainda vendo tudo

```
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Npgsql.EntityFrameworkCore.Tools
```

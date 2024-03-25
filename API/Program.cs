
var builder = WebApplication.CreateBuilder(args);

//Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

//Configure the HTTP request pipeline. 

app.UseAuthentication();

app.MapControllers();

app.Run();

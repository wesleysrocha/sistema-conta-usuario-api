using Microsoft.EntityFrameworkCore;

using SistemaContaUsuario.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ContaUsuarioContext>(opt => opt.UseMySql(

builder.Configuration.GetConnectionString("mysqlConnection"),
 new MySqlServerVersion(new Version())
));


builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    // app.UseSwagger();
    // app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
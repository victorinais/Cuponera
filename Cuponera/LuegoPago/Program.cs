using LuegoPago.Data;
using LuegoPago.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddControllers(); 

builder.Services.AddDbContext<CuponDbContext>(options =>
                            options.UseMySql(
                                builder.Configuration.GetConnectionString("MySqlConnection"),
                                Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddScoped<ICuponRepository, CuponRepository>();// Importante muchachos

builder.Services.AddCors(options =>
{
    options.AddPolicy("NewPolicy", app =>
    {
        app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("NewPolicy");
app.UseHttpsRedirection();
app.MapControllers();
app.Run();

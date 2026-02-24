using FilmesTorloni.WebAPI.Interfaces;
using FilmeTorloni.WebAPI.BdContextFilmes;
using FilmeTorloni.WebAPI.Repositories;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FilmesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();
builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();

app.Run();

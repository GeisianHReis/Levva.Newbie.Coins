using Levva.newbie.coins.Data;
using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Data.Repositories;
using Levva.newbie.coins.Logic.MapperProfiles;
using Levva.newbie.coins.Logic.Services;
using Levva.newbie.coins.Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(DefaulMapper));

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ITransacaoRepository, TransacaoRepository>();

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<ITransacaoService, TransacaoService>();


builder.Services.AddDbContext<Context>(options => options
    .UseSqlite(builder.Configuration
    .GetConnectionString("Default"),b => b.MigrationsAssembly("Levva.newbie.coins")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

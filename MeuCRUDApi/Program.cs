using MeuCRUDApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MeuCRUDApi.Data;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.Options;
using MeuCRUDApi.Repositorios.Interfaces;
using MeuCRUDApi.Repositorios;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();





builder.Services.AddDbContext<SistemaTarefasDBContex>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
);

builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>(); // resolvendo injeção de depedencia, toda vez que algume chamar essa interface (IUsuarioRepositorio), ele vai saber que a classe que ele tem q instaciar é a classe  
builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
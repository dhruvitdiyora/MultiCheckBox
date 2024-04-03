using Microsoft.EntityFrameworkCore;
using MultiSelect.IServices;
using MultiSelect.Models;
using MultiSelect.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// services cors
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultDb");
builder.Services.AddDbContext<ListBoxContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddScoped<IListBox, ListBoxServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("corsapp");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

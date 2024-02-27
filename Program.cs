using Microsoft.EntityFrameworkCore;
using Services.Context;
using Services.Feature.Admins.Interface;
using Services.Feature.Admins.Repository;
using Services.Feature.Admins.Service;
using Services.Shared.Generic.Interface;
using Services.Shared.Generic.Repositories;
using Services.Shared.Static;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FirContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("FIRCONNECTION")));
builder.Services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<AdminService>();
builder.Services.AddScoped<Func<FirContext>>((provider)=>() => provider.GetService<FirContext>());
builder.Services.AddScoped<DbFactory<FirContext>>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

using GoPillBox.Database;
using GoPillBox.Repositories;
using GoPillBox.Repositories.Contracts;
using GoPillBox.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.AddScoped<ILoggingService, LoggingService>();

builder.Services.AddDbContextFactory<GoPillBoxDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("GoPillBoxDb")));

// Add services to the container.
builder.Services.AddScoped<IAlarmEventsRepository, AlarmEventsRepository>();
builder.Services.AddScoped<IUserMedicationsRepository, UserMedicationsRepository>();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<UserAuthenticationService>();

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

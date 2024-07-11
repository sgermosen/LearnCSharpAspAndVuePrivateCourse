using Contacts.Application.Contracts;
using Contacts.Infraestructure.Repositories;
using Contacts.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IContactRepository, ContactEfRepository>();
builder.Services.AddTransient<ContactAdoRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins("https://localhost:7152") // Cambia esta URL por la de tu aplicación web
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

var app = builder.Build();
 
app.UseCors("AllowSpecificOrigin");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

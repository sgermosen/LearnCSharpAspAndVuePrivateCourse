using Contacts.Api.Profile;
using Contacts.Application.Contracts;
using Contacts.Application.Services;
using Contacts.Domain;
using Contacts.Infraestructure.Repositories;
using Contacts.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IContactService, ContactService>();
builder.Services.AddTransient<INotificationService, NotificationService>();
builder.Services.AddTransient<IAppointmentService, AppointmentService>();

builder.Services.AddTransient<IContactRepository, ContactEfRepository>();

builder.Services.AddTransient<IRepository<Contact>, ContactEfRepository>();
builder.Services.AddTransient<IRepository<Notification>, NotificationEfRepository>();
builder.Services.AddTransient<IRepository<Appointment>, AppointmentEfRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

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

using Contacts.Api.Profile;
using Contacts.Application.Contracts;
using Contacts.Application.Services;
using Contacts.Infraestructure.Repositories;
using Contacts.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
  
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IContactRepository, ContactEfRepository>();
//builder.Services.AddTransient<IRepository<TEn>, Repository>();
builder.Services.AddTransient<IContactService, ContactService>(); 
//builder.Services.AddTransient<ContactAdoRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

var frontUrl = builder.Configuration["ApplicationConfiguration:FrontUrl"].ToString();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.WithOrigins(frontUrl) // Cambia esta URL por la de tu aplicación web
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

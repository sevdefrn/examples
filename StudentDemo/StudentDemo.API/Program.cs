using Microsoft.EntityFrameworkCore;
using StudentDemo.Core.Interfaces;
using StudentDemo.Core.Services;
using StudentDemo.Data;
using StudentDemo.Data.Context;
using StudentDemo.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

//// DbContext kaydý
builder.Services.AddDbContext<AppDbContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

/// Repsitory kaytýlarý
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

/// UnitOfWork Kayýt
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

/// Servis kayýtlarý
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();

/// Controller'larý ekle
builder.Services.AddControllers();


/// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = "StudentDemo API",
        Version = "v1",
        Description = "DB First & SOLID Prensipleri Demo API"
    });
});


// ? BURAYA (Build’den önce)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "StudentDemo API v1");
        c.RoutePrefix = "swagger";
    });
}

// ? BURADA (Build’den sonra)
app.UseCors("AllowFrontend");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
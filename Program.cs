using InMemoryCachingAPI.BuisnessLogic;
using InMemoryCachingAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register memory cache
builder.Services.AddMemoryCache();

// Register custom services
builder.Services.AddSingleton<ProductRepository>();
builder.Services.AddSingleton<MemoryCacheService>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

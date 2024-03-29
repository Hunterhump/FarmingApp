using FarmFamAPI.Data;
using FarmFamAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IClimatePredictionService, ClimatePredictionServiceByState>();
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddScoped<IClimatePredictionsNew, ClimatePredictionsNew>();
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddScoped<ICropCompatibilityService, CropCompatibilityService>();
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddScoped<ICropService, CropService>();
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddScoped<ICropTempLimit, CropTempLimit>();
builder.Services.AddDbContext<DbContextClass>();
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

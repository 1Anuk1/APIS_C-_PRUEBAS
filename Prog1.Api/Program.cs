using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod());
});
builder.Services.AddScoped<Prog1.Api.Data.DbContext>();
builder.Services.AddScoped<Prog1.Api.Features.Alumnos.AlumnoService>();

builder.Services.AddOpenApi();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

else
{
    app.UseHttpsRedirection();
}

app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();
app.Run();

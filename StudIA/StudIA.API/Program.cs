using Microsoft.EntityFrameworkCore;
using StudIA.Business;
using StudIA.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<StudIAContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// --- REGISTRAR NUESTRO SERVICIO (NUEVO) ---
builder.Services.AddScoped<MateriaService>();
builder.Services.AddScoped<PomodoroService>();
builder.Services.AddScoped<UsuarioService>();
// ------------------------------------------




// --- 1. CONFIGURACIÓN DE CORS (NUEVO) ---
builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173", "http://localhost:5175") // El puerto por defecto de Vite/React
              .AllowAnyHeader()
              .AllowAnyMethod();

    });
});
// ----------------------------------------

builder.Services.AddControllers();
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

// --- 2. ACTIVAR CORS (NUEVO) ---
app.UseCors("PermitirFrontend");
// -------------------------------

app.UseAuthorization();

app.MapControllers();

app.Run();
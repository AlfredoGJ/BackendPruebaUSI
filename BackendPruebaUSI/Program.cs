using BackendPruebaUSI.Data;
using BackendPruebaUSI.Repositories;
using BackendPruebaUSI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure connection to PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options => { options.UseNpgsql(builder.Configuration.GetConnectionString("EmpleadosDatabase")); });

// Add Repositories
builder.Services.AddScoped<IDireccionesRepository, DireccionesRepository>();
builder.Services.AddScoped<IEmpleadosRepository, EmpleadosRepository>();
builder.Services.AddScoped<IEntidadesFederativasRepository, EntidadesFederativasRepository>();
builder.Services.AddScoped<IGradosDeEstudioRepository, GradoDeEstudiosRepository>();
builder.Services.AddScoped<IPuestosDeTrabajoRepository, PuestoDeTrabajoRepository>();
builder.Services.AddScoped<ITelefonosRepository, TelefonosRepository>();
builder.Services.AddScoped<ITipodDeEmpleadoRepository, TipoEmpleadoRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure cors   
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyOrigin().WithMethods(
                              HttpMethod.Get.Method,
                              HttpMethod.Post.Method,
                              HttpMethod.Delete.Method,
                              HttpMethod.Put.Method
                              ).AllowAnyHeader();
                          
                      });
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(MyAllowSpecificOrigins);
app.MapControllers();

app.Run();

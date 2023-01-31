global using NegosudAPI.Models;
global using NegosudAPI.Data;
using NegosudAPI.Services.ClientService;
using NegosudAPI.Services.ProduitService;
using NegosudAPI.Services.FournisseurService;
using NegosudAPI.Services.CollaborateurService;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<ICollaborateurService, CollaborateurService>();
builder.Services.AddScoped<IProduitService, ProduitService>();
builder.Services.AddScoped<IFournisseurService, FournisseurService>();
builder.Services.AddDbContext<DataContext>();

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
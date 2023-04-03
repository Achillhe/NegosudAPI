global using NegosudAPI.Data;
global using System.Linq;
using BusinessLayer.Services.ClientService;
using BusinessLayer.Services.CollaborateurService;
using BusinessLayer.Services.ProduitService;
using BusinessLayer.Services.FournisseurService;
using BusinessLayer.Services.SortService;
using BusinessLayer.Services.PanierService;
using BusinessLayer.Services.TypeService;
using NegosudAPI.Services.AuthentificationService;
using BusinessLayer.Services.AuthentificationService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<ICollaborateurService, CollaborateurService>();
builder.Services.AddScoped<IProduitService, ProduitService>();
builder.Services.AddScoped<IFournisseurService, FournisseurService>();
builder.Services.AddScoped<ISortService, SortService>();
builder.Services.AddScoped<IPanierService, PanierService>();
builder.Services.AddScoped<IJwtAuthentificationService, JwtAuthentificationService>();
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

app.UseCors(x => x
          .AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader());

app.Run();

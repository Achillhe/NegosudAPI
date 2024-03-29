﻿global using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Models;

namespace NegosudAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=DIFFDB;Trusted_Connection=true;Encrypt=true;TrustServerCertificate=true;");
        
        }

        public DbSet<Client> Clients{get; set;}
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<Collaborateur> Collaborateurs { get; set; }
        public DbSet<Sort> Sorts { get; set; }
        public DbSet<Panier> Paniers { get; set; }
    }
}

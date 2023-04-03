using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using NegosudAPI.Data;

namespace BusinessLayer.Services.ProduitService
{
    public class ProduitService : IProduitService
    {
        private readonly DataContext _context;

        public ProduitService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Produit>> AddProduct(Produit produit)
        {
            _context.Produits.Add(produit);
            await _context.SaveChangesAsync();
            return await _context.Produits.ToListAsync();
        }

        public async Task<List<Produit>?> DeleteProduct(int Id)
        {
            var produit = await _context.Produits.FindAsync(Id); ;
            if (produit is null)
                return null;

            _context.Produits.Remove(produit);
            await _context.SaveChangesAsync();
            return await _context.Produits.ToListAsync();
        }

        public async Task<List<Produit>> GetAllProducts()
        {
            var produits = await _context.Produits.ToListAsync();
            return produits;
        }

        public async Task<Produit?> GetSingleProduct(int Id)
        {
            var produit = await _context.Produits.FindAsync(Id);
            if (produit is null)
                return null;

            return produit;
        }

        public async Task<List<Produit>?> UpdateProduct(int Id, Produit request)
        {
            var produit = await _context.Produits.FindAsync(Id);
            if (produit is null)
                return null;

            produit.NomDomaine = request.NomDomaine;
            produit.Reference = request.Reference;
            produit.Quantite = request.Quantite;
            produit.Prix = request.Prix;
            produit.Volume = request.Volume;
            produit.Millesime = request.Millesime;
            produit.Image = request.Image;

            await _context.SaveChangesAsync();

            return await _context.Produits.ToListAsync();
        }
    }
}

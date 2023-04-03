using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using NegosudAPI.Data;

namespace BusinessLayer.Services.PanierService
{
    public class PanierService : IPanierService
    {
        private readonly DataContext _context;

        public PanierService(DataContext context)
        {
            _context = context;
        }

        public async Task<Panier> AddProduit(int clientId, int produitId, int quantite)
        {
            // Recherche du client
            var client = await _context.Clients.FindAsync(clientId);
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            // Recherche du produit
            var produit = await _context.Produits.FindAsync(produitId);
            if (produit == null)
                throw new ArgumentNullException(nameof(produit));

            // Vérification de la quantité en stock
            if (produit.Quantite < quantite)
                throw new ArgumentOutOfRangeException(nameof(quantite), "Quantité insuffisante en stock.");

            // Recherche du panier du client
            var panier = await _context.Paniers
                .Include(p => p.Produit)
                .SingleOrDefaultAsync(p => p.ClientId == clientId);

            if (panier == null)
            {
                // Création d'un nouveau panier pour le client s'il n'en a pas
                panier = new Panier { ClientId = clientId };
                _context.Paniers.Add(panier);
            }

            //var produitPanier = panier.Produit.FirstOrDefault(p => p.ProduitId == produitId);
            //if (produitPanier == null)
            //{
            //    // Si le produit n'est pas encore dans le panier, on l'ajoute
            //    produitPanier = new ProduitPanier { ProduitId = produitId, Quantite = quantite };
            //    panier.Produit = produitPanier;
            //}
            //else
            //{
            //    // Sinon, on incrémente la quantité
            //    produitPanier.Quantite += quantite;
            //}

            produit.Quantite -= quantite; // On décrémente la quantité en stock du produit
            await _context.SaveChangesAsync(); // Enregistrement des changements

            return panier;
        }
    }
}

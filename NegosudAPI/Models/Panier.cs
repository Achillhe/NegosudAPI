using NegosudAPI.Core;

namespace NegosudAPI.Models
{
    public class Panier : Entity
    {
        public Produit Produit { get; set; }
        public int ProduitId { get; set; }
        public Client Client { get; set; }
        public int ClientId { get; set; }

        public int Quantite { get; set; }
    }
}

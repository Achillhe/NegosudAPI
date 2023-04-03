using DataAccessLayer.Core;
using DataAccessLayer.Models;

namespace DataAccessLayer.Data.Models
{
    public class ProduitPanier : Entity
    {
        public Produit Produit { get; set; }
        public int ProduitId { get; set; }
        public Panier Panier { get; set; }
        public int PanierId { get; set; }

        public int Quantite { get; set; }
    }
}

using NegosudAPI.Core;

namespace NegosudAPI.Models
{
    public class Produit : Entity
    {
        public string type { get; set; }
        public string nom_de_domaine { get; set; }
        public int reference { get; set; }
        public int quantite { get; set; }
        public float prix { get; set; }
        public float volume { get; set; }
        public int millesime { get; set; }

        public Produit() 
        { 
        }

    }
}

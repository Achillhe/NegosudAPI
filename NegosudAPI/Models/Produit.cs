using NegosudAPI.Core;

namespace NegosudAPI.Models
{
    public class Produit : Entity
    {
        public string NomDomaine { get; set; }
        public int Reference { get; set; }
        public int Quantite { get; set; }
        public float Prix { get; set; }
        public float Volume { get; set; }
        public int Millesime { get; set; }

        public int TypeId { get; set; }
    }
}

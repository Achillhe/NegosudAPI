using DataAccessLayer.Core;

namespace DataAccessLayer.Models
{
    public class Produit : Entity
    {
        public string NomDomaine { get; set; }
        public int Reference { get; set; }
        public int Quantite { get; set; }
        public float Prix { get; set; }
        public float Volume { get; set; }
        public int Millesime { get; set; }
        public string Image { get; set; }

        public int SortId { get; set; }
    }
}

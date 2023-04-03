using DataAccessLayer.Core;

namespace DataAccessLayer.Models
{
    public class Fournisseur : Entity
    {
        public string Nom { get; set; }
        public string Email { get; set; }
        public int CodePostal { get; set; }
        public string Pays { get; set; }
        public string Tel { get; set; }
        public int Siret { get; set; }
    }
}

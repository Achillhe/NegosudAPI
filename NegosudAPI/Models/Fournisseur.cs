using NegosudAPI.Core;

namespace NegosudAPI.Models
{
    public class Fournisseur : Entity
    {
        public string nom { get; set; }
        public string email { get; set; }
        public int code_postal { get; set; }
        public string pays { get; set; }
        public string tel { get; set; }
        public int siret { get; set; }

        public Fournisseur()
        {
        }

    }
}

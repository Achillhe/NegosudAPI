using NegosudAPI.Core;

namespace NegosudAPI.Models
{
    public class Client : Entity
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string adresse { get; set; }

        public Client()
        {
            
        }
    }
}

using DataAccessLayer.Core;

namespace DataAccessLayer.Models
{
    public class Client : Entity
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string ConfirmationMotDePasse { get; set; }
    }
}

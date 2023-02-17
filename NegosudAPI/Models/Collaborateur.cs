using NegosudAPI.Core;

namespace NegosudAPI.Models
{
    public class Collaborateur : Entity
    {
        public string Nom { get; set; }
        public string Prenom{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}

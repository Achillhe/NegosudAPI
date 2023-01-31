using NegosudAPI.Core;

namespace NegosudAPI.Models
{
    public class Collaborateur : Entity
    {
        public string nom { get; set; }
        public string prenom{ get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int role { get; set; }

        public Collaborateur()
        {
        }
    }
}

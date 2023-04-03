using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Core
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}

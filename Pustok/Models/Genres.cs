using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Genres
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public bool isSelected { get; set; }
    
    }
}

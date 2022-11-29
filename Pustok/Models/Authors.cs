using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Authors
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Fullname { get; set; }
    }
}

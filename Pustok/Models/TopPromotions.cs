using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class TopPromotions
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(100)]
        public string RedirectUrl { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class BtmPromotions
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title2 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title3 { get; set; }
        
        [MaxLength(50)]
        public string BtnText { get; set; }
        [MaxLength(100)]
        public string RedirectUrl { get; set; }
    }
}

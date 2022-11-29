using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Sliders
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title1 { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title2 { get; set; }
        [Required]
        [MaxLength(200)]
        public string Desc { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(30)]
        public string BtnText { get; set; }
        [MaxLength(100)]
        public string RedirectUrl{ get; set; }
        public int Order{ get; set; }
    }
}

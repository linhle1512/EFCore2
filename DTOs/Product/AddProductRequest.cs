using System.ComponentModel.DataAnnotations;

namespace EFcore.DTOs
{
    public class AddProductRequest
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string Manufacture { get; set; } = null!;
        [Required]
        public int CategoryId { get; set; }
    }
}
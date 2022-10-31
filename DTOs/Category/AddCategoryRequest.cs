using System.ComponentModel.DataAnnotations;

namespace EFcore.DTOs
{
    public class AddCategoryRequest
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = null!;
    }
}
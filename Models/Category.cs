using System.ComponentModel.DataAnnotations;

namespace EFcore.Models
{
    public class Category : BaseEntity<int>
    {
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; } = null!;
    }
}
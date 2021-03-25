using System.ComponentModel.DataAnnotations;

namespace Ubtproduct.Models
{
    public class Category {
[ScaffoldColumn(false)]
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
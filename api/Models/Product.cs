using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ubtproduct.Models

{
    public class Product {

        [ScaffoldColumn(false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
         [Required]
        public bool Active { get; set; }
         [Required]
        public string Image { get; set; }
         [Required]
        public Category Category { get; set; }
    }
}
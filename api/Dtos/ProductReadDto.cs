using Ubtproduct.Models;

namespace Ubtproduct.Dtos

{
    public class ProductReadDto {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
    }
}
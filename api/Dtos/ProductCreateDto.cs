using Ubtproduct.Models;

namespace UbtProduct.Dtos { 
    public class ProductCreateDto {
        public string Name { get; set; }
        public bool Active { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
    }
}
using AutoMapper;
using Ubtproduct.Dtos;
using Ubtproduct.Models;
using UbtProduct.Dtos;

namespace UbtProduct.Profiles {
    public class ProductsProfile  : Profile {
public ProductsProfile() {

    //Source --> Target
CreateMap<Product,ProductReadDto>();
CreateMap<ProductCreateDto,Product>();
}
    }
}
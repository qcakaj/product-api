using AutoMapper;
using Ubtproduct.Dtos;
using Ubtproduct.Models;

namespace UbtProduct.Profiles {
    public class CategoriesProfile  : Profile {
public CategoriesProfile() {
CreateMap<Category,CategoryReadDto>();
}
    }
}
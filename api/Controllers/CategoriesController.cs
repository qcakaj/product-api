using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ubtproduct.Data;
using Ubtproduct.Dtos;

namespace UbtProduct.Controllers
{
    [Route("api/products/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IUbtProductRepo _repository;
        private readonly IMapper _mapper;

        public CategoriesController(IUbtProductRepo repository, IMapper mapper ) {
            _repository=repository;
            _mapper=mapper;

        }
         [HttpGet]
        public ActionResult<IEnumerable<CategoryReadDto>> getAllCategories()
        {
            var categoryItems = _repository.getAllCategories();

            return Ok(_mapper.Map<IEnumerable<CategoryReadDto>>(categoryItems));
        }

         [HttpGet("{id}")]
        public ActionResult<CategoryReadDto> getCategoryById(int id)
        {
            var categoryItem = _repository.getCategoryById(id);
            if(categoryItem != null) {
                 return Ok(_mapper.Map<CategoryReadDto>(categoryItem));
            }

            return NotFound();
           
        }
    }
}
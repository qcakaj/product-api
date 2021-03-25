using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Ubtproduct.Data;
using Ubtproduct.Dtos;
using Ubtproduct.Models;
using UbtProduct.Dtos;

namespace UbtProduct.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUbtProductRepo _repository;
        private readonly IMapper _mapper;

        public ProductsController(IUbtProductRepo repository, IMapper mapper){
           _repository=repository;
           _mapper= mapper;
       }
        [HttpGet]
        public ActionResult<IEnumerable<ProductReadDto>> getAllProducts()
        {
            var productItems = _repository.getAllProducts();
            if(productItems == null) return NotFound();

            return Ok(_mapper.Map<IEnumerable<ProductReadDto>>(productItems));
        }

    

        [HttpGet("{id}", Name="getProductById")]
        public ActionResult<ProductReadDto> getProductById(int id)
        {
            var productItem = _repository.getProductById(id);
            if(productItem != null) {
                 return Ok(_mapper.Map<ProductReadDto>(productItem));
            }

            return NotFound();
           
        }

        [HttpPost]
        public ActionResult<ProductReadDto> createProduct(ProductCreateDto productCreateDto) {
            var productModel = _mapper.Map<Product>(productCreateDto);
            _repository.createProduct(productModel);
            _repository.SaveChanges(); 

            var productReadDto = _mapper.Map<ProductReadDto>(productModel);

            return CreatedAtRoute(nameof(getProductById), new {Id = productReadDto.Id},productReadDto);
            // return Ok(productReadDto);
        }

    }
}
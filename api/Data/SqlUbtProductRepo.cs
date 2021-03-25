using System;
using System.Collections.Generic;
using System.Linq;
using Ubtproduct.Data;
using Ubtproduct.Models;

namespace UbtProduct.Data {
    public class SqlUbtProductRepo : IUbtProductRepo
    {
        private readonly UbtProductContext _context;

        public SqlUbtProductRepo(UbtProductContext context) {
            _context=context;
        }

        public void createProduct(Product prod)
        {
            if(prod == null){
                throw new ArgumentNullException(nameof(prod)); 
            }
            _context.Add(prod);
        }

        public IEnumerable<Category> getAllCategories()
        {
            return _context.UbtProductsCategories.ToList();
        }

        public IEnumerable<Product> getAllProducts()
        {
            return _context.UbtProducts.ToList();
        }

        public Category getCategoryById(int id)
        {
            return _context.UbtProductsCategories.FirstOrDefault(p => p.Id == id);
        }

        public Product getProductById(int id)
        {
            return _context.UbtProducts.FirstOrDefault(p=> p.Id == id);
        }

        public bool SaveChanges()
        {
           return (_context.SaveChanges() >= 0);
        }
    }
}
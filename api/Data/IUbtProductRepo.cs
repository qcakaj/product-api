using System.Collections.Generic;
using Ubtproduct.Models;

namespace Ubtproduct.Data
{
    public interface IUbtProductRepo
    {

        bool SaveChanges();
        IEnumerable<Product> getAllProducts();
        Product getProductById(int id);

        IEnumerable<Category> getAllCategories();

        Category getCategoryById(int id);

        void createProduct(Product prod);
    }
}
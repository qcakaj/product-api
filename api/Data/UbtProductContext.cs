using Microsoft.EntityFrameworkCore;
using Ubtproduct.Models;

namespace UbtProduct.Data {
    public class UbtProductContext : DbContext {
public UbtProductContext(DbContextOptions<UbtProductContext> opt) : base(opt) {

}

public DbSet<Product> UbtProducts {get;set;}
public DbSet<Category> UbtProductsCategories{get;set;}

   }
}
using System;
using Microsoft.EntityFrameworkCore;
using ShopASucculent.Data.Model;

namespace ShopASucculent.Data
{
    public class ShopDBContext : DbContext
    {
        public ShopDBContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Succulent> Succulents { get; set; }
    }
}

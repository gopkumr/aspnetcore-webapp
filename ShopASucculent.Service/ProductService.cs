using Microsoft.EntityFrameworkCore;
using ShopASucculent.Data;
using ShopASucculent.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopASucculent.Service
{
    public class ProductService : IProductService
    {
        ShopDBContext _dbContext;

        public ProductService(ShopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product AddNewProduct(Product newProduct)
        {
            newProduct.Id = Guid.Empty;
            _dbContext.ProductCategories.Attach(newProduct.Category);
            _dbContext.Products.Add(newProduct);
            _dbContext.SaveChanges();
            return newProduct;
        }

        public ProductCategory AddNewProductCategory(ProductCategory productCategory)
        {
            _dbContext.ProductCategories.Add(productCategory);
            _dbContext.SaveChanges();
            return productCategory;
        }

        public IEnumerable<ProductCategory> GetAllProductCategories()
        {
            return _dbContext.ProductCategories;
        }

        public Product GetProduct(Guid id)
        {
            var product = _dbContext.Products
                    .Include(q => q.Category)
                    .FirstOrDefault(q => q.Id == id);

            return product;
        }

        public IEnumerable<Product> GetProductsByCategory(ProductCategory productCategory)
        {
            if (productCategory == null)
                return _dbContext.Products
                   .Include(q => q.Category);

                var products = _dbContext.Products
                       .Include(q => q.Category)
                       .Where(q => q.Category.Id == productCategory.Id);
            return products;
        }

        public void ReduceProductQuantity(Guid id, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}

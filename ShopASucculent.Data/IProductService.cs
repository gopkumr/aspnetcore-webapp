using ShopASucculent.Data.Model;
using System;
using System.Collections.Generic;

namespace ShopASucculent.Data
{
    public interface IProductService
    {
        Product GetProduct(Guid id);
        Product AddNewProduct(Product newProduct);
        void ReduceProductQuantity(Guid id, int quantity);
        IEnumerable<Product> GetProductsByCategory(ProductCategory productCategory);

        IEnumerable<ProductCategory> GetAllProductCategories();
        ProductCategory AddNewProductCategory(ProductCategory productCategory);

    }
}

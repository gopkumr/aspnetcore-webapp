using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopASucculent.Data;
using ShopASucculent.Data.Model;
using ShopASucculent.Models;

namespace ShopASucculent.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index(int SelectCategoryId)
        {
            var categoryId = SelectCategoryId == 0 ? 1 : SelectCategoryId;
            var productCategories = productService.GetAllProductCategories().ToList();
            var products = productService.GetProductsByCategory(productCategories.FirstOrDefault(q=>q.Id== categoryId)).ToList();
            return View(new ProductsListViewModel {SelectCategoryId=categoryId, ProductCategories = productCategories, Products = products });
        }

        public IActionResult  CreateProduct()
        {
            var productCategories = productService.GetAllProductCategories().ToList();
            return View(new AddNewProductViewModel { ProductCategories = productCategories, ProductData = new Product() });
        }

        [HttpPost]
        public IActionResult CreateProduct(AddNewProductViewModel model)
        {
            productService.AddNewProduct(model.ProductData);
            return RedirectToAction("Index");
        }

        public IActionResult ProductCategoryList()
        {
            var allCategories = this.productService.GetAllProductCategories();

            return View(new ProductCategoryViewModel { ProductCategories = allCategories });
        }

        public IActionResult CreateProductCategory()
        {
            return View(new ProductCategoryViewModel() { ProductCategory=new Data.Model.ProductCategory() });
        }

        [HttpPost]
        public IActionResult CreateProductCategory(Data.Model.ProductCategory productCategory)
        {
            this.productService.AddNewProductCategory(productCategory);
            return RedirectToAction("CreateProduct");
        }
    }
}
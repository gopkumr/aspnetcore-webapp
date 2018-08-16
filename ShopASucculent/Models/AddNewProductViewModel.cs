using ShopASucculent.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopASucculent.Models
{
    public class AddNewProductViewModel
    {
        public Product ProductData { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}

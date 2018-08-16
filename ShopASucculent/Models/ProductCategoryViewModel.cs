﻿using ShopASucculent.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopASucculent.Models
{
    public class ProductCategoryViewModel
    {
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}

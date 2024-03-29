﻿using MyShop.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.ViewModels
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<ProductCategory> productCategories { get; set; }
    }
}

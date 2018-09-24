﻿using System.Collections.Generic;

namespace TestCodeFirstEFCore.Models
{
    public class Product
    {
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public List<ProductCategory> ProductCategories
        {
            get; set;
        }
    }
}

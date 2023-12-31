﻿using BitirmeProjesi.DAL.Entities;

namespace BitirmeProjesi.UI.Areas.admin.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }

        public IEnumerable<Category>Categories { get; set; }
        public IEnumerable<Brand>Brands { get; set; }
    }
}

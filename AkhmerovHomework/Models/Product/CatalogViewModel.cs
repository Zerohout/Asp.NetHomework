﻿using System.Collections.Generic;

namespace AkhmerovHomework.Models.Product
{
    public class CatalogViewModel
    {
        public int? BrandId { get; set; }
        public int? SectionId { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}

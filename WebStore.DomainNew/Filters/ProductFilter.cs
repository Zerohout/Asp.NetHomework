﻿using System.Collections.Generic;

namespace WebStore.DomainNew.Filters
{
    /// <summary>
    /// Класс для фильтрации товаров
    /// </summary>
    public class ProductFilter
    {
        /// <summary>
        /// Секция к которой принадлежит товар
        /// </summary>
        public int? SectionId { get; set; }

        /// <summary>
        /// Бренд товара
        /// </summary>
        public int? BrandId { get; set; }

        /// <summary>
        /// Id товара
        /// </summary>
        public List<int> Ids { get; set; }
    }
}

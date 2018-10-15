﻿using System.Collections.Generic;
using WebStore.DomainNew.Dto.Product;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Filters;

namespace WebStore.Interfaces.Services
{
    /// <summary>
    /// Интерфейс для работы с товарами
    /// </summary>
    public interface IProductData
    {
        /// <summary>
        /// Список секций
        /// </summary>
        /// <returns></returns>
        List<Section> GetSections();

        /// <summary>
        /// Список брендов
        /// </summary>
        /// <returns></returns>
        List<Brand> GetBrands();

        /// <summary>
        /// Список товаров
        /// </summary>
        /// <param name="filter">Фильтр товаров</param>
        /// <returns></returns>
        IEnumerable<ProductDto> GetProducts(ProductFilter filter);

        /// <summary>
        /// Продукт
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Сущность Product, если нашёл, иначе null</returns>
        ProductDto GetProductById(int id);
    }
}

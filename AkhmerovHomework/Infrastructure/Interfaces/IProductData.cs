using System.Collections.Generic;
using AkhmerovHomework.Domain.Filters;
using AkhmerovHomework.Domain.Entities;

namespace AkhmerovHomework.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();
        IEnumerable<Brand> GetBrands();
        IEnumerable<Product> GetProducts(ProductFilter filter);
    }
}

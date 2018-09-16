using AkhmerovHomeWork1.Domain.Entities;
using AkhmerovHomeWork1.Domain.Filters;
using System.Collections.Generic;

namespace AkhmerovHomework1.Infrastructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Section> GetSections();

        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter filter);
    }
}

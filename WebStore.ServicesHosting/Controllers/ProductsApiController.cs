using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebStore.DomainNew.Dto.Product;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Filters;
using WebStore.Interfaces.Services;

namespace WebStore.ServicesHosting.Controllers
{
    [Produces("application/json")]
    [Route("api/products")]
    public class ProductsApiController : Controller, IProductData
    {
        private readonly IProductData _productData;
        public ProductsApiController(IProductData productData)
        {
            _productData = productData;
        }
        [HttpGet("sections")]
        public List<Section> GetSections()
        {
            return _productData.GetSections();
        }
        [HttpGet("brands")]
        public List<Brand> GetBrands()
        {
            return _productData.GetBrands();
        }
        [HttpPost]
        [ActionName("Post")]
        public IEnumerable<ProductDto> GetProducts([FromBody]ProductFilter
            filter)
        {
            return _productData.GetProducts(filter);
        }
        [HttpGet("{id}"), ActionName("Get")]
        public ProductDto GetProductById(int id)
        {
            var product = _productData.GetProductById(id);
            return product;
        }
    }
}
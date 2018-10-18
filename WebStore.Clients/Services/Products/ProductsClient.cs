using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Configuration;
using WebStore.Clients.Base;
using WebStore.DomainNew.Dto.Product;
using WebStore.DomainNew.Entities;
using WebStore.DomainNew.Filters;
using WebStore.Interfaces.Services;

namespace WebStore.Clients.Services.Products
{
    public class ProductsClient : BaseClient, IProductData
    {
        public ProductsClient(IConfiguration configuration) :
            base(configuration)
        {
            ServiceAddress = "api/products";
        }
        protected sealed override string ServiceAddress { get; set; }
        public List<Section> GetSections()
        {
            var url = $"{ServiceAddress}/sections";
            var result = Get<List<Section>>(url);
            return result;
        }
        public List<Brand> GetBrands()
        {
            var url = $"{ServiceAddress}/brands";
            var result = Get<List<Brand>>(url);
            return result;
        }
        public IEnumerable<ProductDto> GetProducts(ProductFilter filter)
        {
            var url = $"{ServiceAddress}";
            var response = Post(url, filter);
            var result =
                response.Content.ReadAsAsync<IEnumerable<ProductDto>>().Result;
            return result;
        }
        public ProductDto GetProductById(int id)
        {
            var url = $"{ServiceAddress}/{id}";
            var result = Get<ProductDto>(url);
            return result;
        }
    }
}

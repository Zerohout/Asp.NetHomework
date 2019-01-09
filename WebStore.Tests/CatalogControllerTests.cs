using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebStore.Controllers;
using WebStore.DomainNew.Dto.Product;
using WebStore.DomainNew.Filters;
using WebStore.DomainNew.ViewModel.Product;
using WebStore.Interfaces.Services;

namespace WebStore.Tests
{
    [TestClass]
    public class CatalogControllerTests
    {
        [TestMethod]
        public void ProductDetails_Returns_View_With_Correct_Item(IConfiguration configuration)
        {
            // Arrange
            var productMock = new Mock<IProductData>();
            productMock.Setup(p => p.GetProductById(It.IsAny<int>())).Returns(new ProductDto()
            {
                Id = 1,
                Name = "Test",
                ImageUrl = "TestImage.jpg",
                Order = 0,
                Price = 10,
                Brand = new BrandDto()
                {
                    Id = 1,
                    Name = "TestBrand"
                }
            });
            var controller = new CatalogController(productMock.Object, configuration);

            // Act
            var result = controller.ProductDetails(1);

            // Assert
            var viewResult = Xunit.Assert.IsType<ViewResult>(result);
            var model = Xunit.Assert.IsAssignableFrom<ProductViewModel>(
                viewResult.ViewData.Model);
            Xunit.Assert.Equal(1, model.Id);
            Xunit.Assert.Equal("Test", model.Name);
            Xunit.Assert.Equal(10, model.Price);
            Xunit.Assert.Equal("TestBrand", model.Brand);
        }

        [TestMethod]
        public void ProductDetails_Returns_NotFound(IConfiguration configuration)
        {
            // Arrange
            var productMock = new Mock<IProductData>();
            productMock.Setup(p => p.GetProductById(It.IsAny<int>())).Returns((ProductDto)null);
            var controller = new CatalogController(productMock.Object, configuration);

            // Act
            var result = controller.ProductDetails(1);

            // Assert
            Xunit.Assert.IsType<NotFoundResult>(result);
        }

        [TestMethod]
        public void Shop_Method_Returns_Correct_View(IConfiguration configuration)
        {
            // Arrange
            var productMock = new Mock<IProductData>();
            
            var controller = new CatalogController(productMock.Object, configuration);

            // Act
            var result = controller.Shop(1, 5);

            // Assert
            var viewResult = Xunit.Assert.IsType<ViewResult>(result);
            var model = Xunit.Assert.IsAssignableFrom<CatalogViewModel>(
                viewResult.ViewData.Model);

            Xunit.Assert.Equal(2, model.Products.Count());
            Xunit.Assert.Equal(5, model.BrandId);
            Xunit.Assert.Equal(1, model.SectionId);
            Xunit.Assert.Equal("TestImage2.jpg", model.Products.ToList()[1].ImageUrl);
        }

    }
}

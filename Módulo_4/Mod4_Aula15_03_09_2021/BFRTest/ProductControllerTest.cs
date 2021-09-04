using BlueFashionRetailer.API;
using BlueFashionRetailer.Controllers;
using BlueFashionRetailer.Models;
using BlueFashionRetailer.Services;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BFRTest
{
    public class ProductControllerTest
    {
        int ProductQuantity = 10;
        List<Product> fakeProducts;

        public ProductControllerTest()
        {
            fakeProducts = new List<Product>();
            for (var i = 1; i <= ProductQuantity; i++)
                fakeProducts.Add(new Product { Id = i, Name = $"Prod {i}" });
        }






        [Fact]
        public void GetProducts_Returns_The_Correct_Products()
        {
            var productService = A.Fake<IProductService>();
            A.CallTo(() => productService.All()).Returns(fakeProducts);
            var controller = new ProductController(productService);

            OkObjectResult result = controller.Index() as OkObjectResult;

            var values = result.Value as APIResponse<List<Product>>;
            Assert.True(
                values.Results == fakeProducts &&
                values.Message == "" &&
                values.Succeed
            );
        }






        //[Theory]
        //[InlineData(1)]
        //[InlineData(3)]
        //[InlineData(5)]
        //public void GetProduct_Return_Product_By_Id(int? id)
        //{
        //    var productService = A.Fake<IProductService>();
        //    A.CallTo(() => productService.Get(id)).Returns(fakeProducts.Find(p => p.Id == id));

        //    var controller = new ProductController(productService);

        //    ObjectResult result = controller.Index(id) as OkObjectResult;

        //    var values = result.Value as APIResponse<Product>;
        //    Assert.True(
        //        values.Succeed == true &&
        //        values.Results == fakeProducts.Find(p => p.Id == id)
        //    );
        //}







        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(0, "Não foi encontrado o produto solicitado.", false)]
        [InlineData(579, "Não foi encontrado o produto solicitado.", false)]
        [InlineData(-55, "Não foi encontrado o produto solicitado.", false)]
        [InlineData(null, "Não foi encontrado o produto solicitado.", false)]
        [InlineData(14, "Não foi encontrado o produto solicitado.", false)]
        public void GetProduct_Return_Product_By_Id(int? id, string message = "", bool succeed = true)
        {
            var productService = A.Fake<IProductService>();
            A.CallTo(() => productService.Get(id)).Returns(fakeProducts.Find(p => p.Id == id));

            var controller = new ProductController(productService);

            ObjectResult result = controller.Index(id) as ObjectResult;

            var exists = fakeProducts.Find(p => p.Id == id) != null;
            if (exists)
            {

                var values = result.Value as APIResponse<Product>;
                Assert.True(
                    values.Message == message &&
                    values.Succeed == succeed &&
                    values.Results == fakeProducts.Find(p => p.Id == id)
                );
            }
            else
            {
                var values = result.Value as APIResponse<string>;
                Assert.True(
                    values.Message == message &&
                    values.Succeed == succeed &&
                    values.Results == null
                );
            }
        }

    }
}




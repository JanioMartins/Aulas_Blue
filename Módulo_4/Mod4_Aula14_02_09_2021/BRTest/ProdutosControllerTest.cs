using BlueRuhe.API;
using BlueRuhe.Controllers;
using BlueRuhe.Model;
using BlueRuhe.Services;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BRTest
{
    public class ProdutosControllerTest
    {
        int ProdutosQuantity = 10;
        List<Produtos> fakeProdutos;

        public ProdutosControllerTest()
        {
            fakeProdutos = new List<Produtos>();
            for (var i = 1; i <= ProdutosQuantity; i++)
                fakeProdutos.Add(new Produtos { Id = i, Descricao = $"Prod {i}" });
        }






        [Fact]
        public void GetProdutos_Returns_The_Correct_Produtos()
        {
            var produtosService = A.Fake<IProdutosService>();
            A.CallTo(() => produtosService.All()).Returns(fakeProdutos);
            var controller = new ProdutosController(produtosService);

            OkObjectResult result = controller.Index() as OkObjectResult;

            var values = result.Value as APIResponse<List<Produtos>>;
            Assert.True(
                values.Results == fakeProdutos &&
                values.Message == "" &&
                values.Succeed
            );
        }






        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(0, "Não foi encontrado o produto solicitado!", false)]
        [InlineData(579, "Não foi encontrado o produto solicitado!", false)]
        [InlineData(-55, "Não foi encontrado o produto solicitado!", false)]
        [InlineData(null, "Não foi encontrado o produto solicitado!", false)]
        [InlineData(14, "Não foi encontrado o produto solicitado!", false)]
        public void GetProdutos_Return_Produtos_By_Id(int? id, string message = "", bool succeed = true)
        {
            var produtosService = A.Fake<IProdutosService>();
            A.CallTo(() => produtosService.Get(id)).Returns(fakeProdutos.Find(p => p.Id == id));

            var controller = new ProdutosController(produtosService);

            ObjectResult result = controller.Index(id) as ObjectResult;

            var exists = fakeProdutos.Find(p => p.Id == id) != null;
            if (exists)
            {

                var values = result.Value as APIResponse<Produtos>;
                Assert.True(
                    values.Message == message &&
                    values.Succeed == succeed &&
                    values.Results == fakeProdutos.Find(p => p.Id == id)
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

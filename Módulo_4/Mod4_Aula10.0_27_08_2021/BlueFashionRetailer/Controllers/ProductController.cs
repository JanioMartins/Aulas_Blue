using BlueFashionRetailer.API;
using BlueFashionRetailer.Models;
using BlueFashionRetailer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ApiBaseController
    {
        IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index() => ApiOk(_service.All());



        [AuthorizeRoles(RoleType.Admin)]
        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id) =>
            _service.Get(id) == null ?
                ApiNotFound("Não foi encontrado o produto solicitado!") :
                ApiOk(_service.Get(id));


        [AuthorizeRoles(RoleType.Admin)]
        [Route("Random"), HttpGet]
        public IActionResult Random()
        {
            Random aleatorio = new Random();
            List<Product> lista = _service.All();
            return ApiOk(lista[aleatorio.Next(lista.Count)]);
        }


        [AuthorizeRoles(RoleType.Admin)]
        [HttpPost]
        public IActionResult Create([FromBody] Product prod) =>
            _service.Create(prod, User.Identity.Name) ?
                ApiOk("Produto criado com sucesso!") :
                ApiNotFound("Erro ao criar o produto!");



        [AuthorizeRoles(RoleType.Admin)]
        [HttpPut]
        public IActionResult Update([FromBody] Product prod) =>
            _service.Update(prod, User.Identity.Name) ?
                ApiOk("O produto foi atualizado com sucesso!") :
                ApiNotFound("Erro ao atualizar o produto!");



        [AuthorizeRoles(RoleType.Admin)]
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
                ApiOk("O produto foi deletado com sucesso!") :
                ApiNotFound("Erro ao deletar o produto!");

    }
}

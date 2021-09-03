using BlueRuhe.API;
using BlueRuhe.Model;
using BlueRuhe.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueRuhe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ApiBaseController
    {
        IProdutosService _service;

        public ProdutosController(IProdutosService service)
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

            Random aleartorio = new Random();
            List<Produtos> lista = _service.All();
            return ApiOk(lista[aleartorio.Next(lista.Count)]);

        }


        [AuthorizeRoles(RoleType.Admin)]
        [HttpPost]
        public IActionResult Create([FromBody] Produtos prod) =>
            _service.Create(prod) ?
                ApiOk("Produto criado com sucesso!") :
                ApiNotFound("Erro ao criar o produto!");


        [AuthorizeRoles(RoleType.Admin)]
        [HttpPut]
        public IActionResult Update([FromBody] Produtos prod) =>
            _service.Update(prod, User.Identity.Name) ?
                ApiOk("Produto atualizado com sucesso!") :
                ApiNotFound("Erro ao atualizar produto!");


        [AuthorizeRoles(RoleType.Admin)]
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
                ApiOk("O produto foi deletado com sucesso!") :
                ApiNotFound("Erro ao deletar o produto!");

    }
}

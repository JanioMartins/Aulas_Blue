using BlueRuhe.Model;
using BlueRuhe.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueRuhe.Controllers
{
    public class ProdutosController : ApiBaseController
    {
        IProdutosService _service;

        public ProdutosController(IProdutosService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index() => ApiOk(_service.All());


        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id) =>
            _service.Get(id) == null ?
                ApiNotFound("Não foi encontrado o produto solicitado!") :
                ApiOk(_service.Get(id));



        [Route("Random"), HttpGet]
        public IActionResult Random()
        {

            Random aleartorio = new Random();
            List<Produtos> lista = _service.All();
            return ApiOk(lista[aleartorio.Next(lista.Count)]);

        }


        [HttpPost]
        public IActionResult Create([FromBody] Produtos prod) =>
            _service.Create(prod) ?
                ApiOk("Produto criado com sucesso!") :
                ApiNotFound("Erro ao criar o produto!");


        [HttpPut]
        public IActionResult Update([FromBody] Produtos prod) =>
            _service.Update(prod) ?
                ApiOk("O produto foi atualizado com sucesso!") :
                ApiNotFound("Erro ao atualizar o produto!");


        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
                ApiOk("O produto foi deletado com sucesso!") :
                ApiNotFound("Erro ao deletar o produto!");

    }
}

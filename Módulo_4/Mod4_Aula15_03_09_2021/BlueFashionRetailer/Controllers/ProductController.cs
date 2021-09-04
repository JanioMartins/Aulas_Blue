using BlueFashionRetailer.API;
using BlueFashionRetailer.Models;
using BlueFashionRetailer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Controllers
{
    //[Authorize(Roles = "Common")]
    [AuthorizeRoles(RoleType.Common, RoleType.Admin)]
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ApiBaseController
    {
        IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }


        /// <summary>
        /// Retorna uma lista de todos os produtos existentes no banco de dados.
        /// </summary>
        /// <returns></returns>
        /// 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public IActionResult Index() =>
            ApiOk(_service.All());



        /// <summary>
        /// Retorna um produto específico de acordo com o Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            Product exists = _service.Get(id);
            return exists == null?
                ApiNotFound("Não foi encontrado o produto solicitado.") :
                ApiOk(exists);
        }


        /// <summary>
        ///Cria um novo produto no banco de dados.
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] Product prod)
        {
            prod.createdById = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return _service.Create(prod) ?
                ApiOk("Produto criado com sucesso!") :
                ApiNotFound("Erro ao criar produto!");
        } 

        /// <summary>
        /// Atualiza um produto no banco de dados.
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update([FromBody] Product prod)
        {
            prod.updatedById = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return _service.Update(prod) ?
                ApiOk("Produto atualizado com sucesso!") :
                ApiNotFound("Erro ao atualizar produto!");
        }


        /// <summary>
        /// Apaga o registro de um produto de acordo com o Id no banco de dados.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [AuthorizeRoles(RoleType.Admin)]
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
                ApiOk("Produto deletado com sucesso!") :
                ApiNotFound("Erro ao deletar produto!");


        /// <summary>
        /// Atribui o usuário resposável pela criação e alteração do registro no banco de dados.
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [Route("ProductsByRole/{role?}")]
        [HttpGet]
        public IActionResult ProductsByRole(string role)
        {
            return ApiOk(_service.ProductsByUserRole(role));
        }
    }
}

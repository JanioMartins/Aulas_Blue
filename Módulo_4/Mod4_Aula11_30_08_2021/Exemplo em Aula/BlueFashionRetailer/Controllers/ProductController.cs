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

        [HttpGet]
        public IActionResult Index() =>
            ApiOk(_service.All());


        
        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            Product exists = _service.Get(id);
            return exists == null?
                ApiNotFound("Não foi encontrado o produto solicitado.") :
                ApiOk(exists);
        }


        
        [HttpPost]
        public IActionResult Create([FromBody] Product prod)
        {
            prod.createdById = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return _service.Create(prod) ?
                ApiOk("Produto criado com sucesso!") :
                ApiNotFound("Erro ao criar produto!");
        } 

        
        [HttpPut]
        public IActionResult Update([FromBody] Product prod)
        {
            prod.updatedById = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            return _service.Update(prod) ?
                ApiOk("Produto atualizado com sucesso!") :
                ApiNotFound("Erro ao atualizar produto!");
        }

        [AuthorizeRoles(RoleType.Admin)]
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id) =>
            _service.Delete(id) ?
                ApiOk("Produto deletado com sucesso!") :
                ApiNotFound("Erro ao deletar produto!");


        [AllowAnonymous]
        [Route("ProductsByRole/{role?}")]
        [HttpGet]
        public IActionResult ProductsByRole(string role)
        {
            return ApiOk(_service.ProductsByUserRole(role));
        }
    }
}

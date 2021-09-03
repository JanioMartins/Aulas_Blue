using BlueFashionRetailer.API;
using BlueFashionRetailer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductController : ControllerBase
    {

        List<Product> All()
        {

            List<Product> lista = new List<Product>();
            lista.Add(new Product() { Id = 1, Name = "Camiseta Regata", Price = 30, Description = "Descrição 1" });
            lista.Add(new Product() { Id = 2, Name = "Camiseta Manga Longa", Price = 100, Description = "Descrição 2" });
            lista.Add(new Product() { Id = 3, Name = "Camiseta Polo", Price = 120, Description = "Descrição 3" });
            lista.Add(new Product() { Id = 4, Name = "Camisa Social", Price = 80, Description = "Descrição 4" });
            lista.Add(new Product() { Id = 5, Name = "Camiseta Estampada", Price = 90, Description = "Descrição 5" });

            return lista;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new APIResponse<List<Product>>() { Results = All() });
        }


        [Route("{id}")]
        [HttpGet]
        public IActionResult Index(int? id)
        {
            Product produtoExistente = All().Find(p => p.Id == id);
            var response = new APIResponse<Product>();
            if (produtoExistente == null)
            {
                response.Error = "Não foi encontrado o produto solicitado!";
                return NotFound(response);
            }
            else
            {
                response.Results = produtoExistente;
                return Ok(response);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product prod)
        {
            List<Product> products = All();
            prod.Id = products.Max(p => p.Id) + 1;
            Product exists = All().Find(p => p.Name == prod.Name);
            var response = new APIResponse<Product>();
            if (exists == null)
            {
                response.Results = prod;
                return Ok(response);
            }
            else
            {
                response.Error = "Já existe um produto com o Nome informado!";
                return NotFound(response);
            }
        }


        [HttpPut]
        public IActionResult Update([FromBody] Product prod)
        {
            List<Product> products = All();
            prod.Id = products.Max(p => p.Id) + 1;
            Product exists = All().Find(p => p.Name == prod.Name);
            var response = new APIResponse<Product>();
            if (exists == null)
            {
                response.Results = prod;
                return Ok(response);
            }
            else
            {
                response.Error = "Já existe um produto com o Nome informado!";
                return NotFound(response);
            }
        }

        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            Product exists = All().Find(p => p.Id == id);
            var response = new APIResponse<string>();

            if (exists == null)
            {
                response.Error = "Não foi encontrado o produto solicitado!";
                return NotFound(response);
            }

            else
            {
                response.Results = "Produto excluído com sucesso!";
                return Ok(response);
            }
        }
    }
}

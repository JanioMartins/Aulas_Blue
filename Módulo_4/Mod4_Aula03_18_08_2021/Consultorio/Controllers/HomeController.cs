using Consultorio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ////IFuncionarioFinanceiro a = new Arquiteto();


            //Desenvolvedor f1 = new Desenvolvedor("Cleiton") { salario = 15000 };
            //Gerente f2 = new Gerente("Hyago") { salario = 50000 };
            ////Funcionario f3 = new Funcionario("Thales") { salario = 5000 };


            //IFuncionarioFinanceiro gerenteFinanceiro = f2;
            //Funcionario gerenteAbstrato = f2;


            //List<Funcionario> lista = new();
            //lista.Add(f1);
            //lista.Add(f2);
            ////lista.Add(f3);


            //return Ok(lista);

            ////return View();
            ///

            //try
            //{
            //    saque(-1, 50);
            //}
            //catch (Exception e)
            //{
            //    return Ok(e.Message);
            //}


            //return Ok("saque ok");
            return View();
        }

        int saque(int x, int saldo)
        {
            if (x < 1)
                throw new AccessViolationException("Saque invalido");
            if (x > saldo)
                throw new ApplicationException("Você não tem saldo disponível!");

            return saldo - x;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using BlueDev.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Controllers
{
    public class LinguagensController : Controller
    {
        public IActionResult Index()
        {
            List<Linguagens> ListaLinguagens = GetLinguagens();
            return View(ListaLinguagens);
        }
        List<Linguagens> GetLinguagens()
        {
            List<Linguagens> ListaLinguagens = new List<Linguagens>();
        }
    }
}

using BlueDev.Models;
using BlueDev.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Controllers
{
    //Controllers são responsáveis por trabalhar e buscar dados que serão utilizados para o usuário.
    public class LinguagensController : Controller
    {
        ILinguagensService service;

        public LinguagensController(ILinguagensService service)
        {
            this.service = service;
        }

        public IActionResult Index(string busca, bool ordenar = false)
        {
            ViewBag.ordenar = ordenar;
            Random r = new Random();

            return View(service.getAll(busca, ordenar));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Linguagens linguagens)
        {
            if (!ModelState.IsValid) return View(linguagens);

            return service.create(linguagens) ?
                RedirectToAction(nameof(Index)) :
                View(linguagens);
        }


        public IActionResult Read(int? id)
        {
            Linguagens linguagens = service.get(id);
            return linguagens != null ?
                View(linguagens) :
                NotFound();
        }

        public IActionResult Update(int? id)
        {
            Linguagens linguagens = service.get(id);
            return linguagens != null ?
                View(linguagens) :
                NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Linguagens linguagens)
        {
            if (!ModelState.IsValid) return View(linguagens);

            if (service.update(linguagens)) 
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(linguagens);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (service.delete(id)) 
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }
    }
}

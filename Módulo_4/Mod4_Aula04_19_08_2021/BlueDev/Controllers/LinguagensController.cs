using BlueDev.Models;
using BlueDev.Services;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Linguagens linguagens)
        {
            if (!ModelState.IsValid) return View(linguagens);

            return service.create(linguagens) ?
                RedirectToAction(nameof(Index)) :
                View(linguagens);
        }

        [Authorize]
        public IActionResult Read(int? id)
        {
            Linguagens linguagens = service.get(id);
            return linguagens != null ?
                View(linguagens) :
                NotFound();
        }

        [Authorize]
        public IActionResult Update(int? id)
        {
            Linguagens linguagens = service.getAll().FirstOrDefault(x => x.Id == id);
            //return linguagens != null ?
            //View(linguagens) : 
            //NotFound();
            return View(linguagens);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Linguagens linguagens)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(linguagens);
            //}


            if (service.update(linguagens)) 
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
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

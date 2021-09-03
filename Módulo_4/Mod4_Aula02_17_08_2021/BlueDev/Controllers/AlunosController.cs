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
    public class AlunosController : Controller
    {
        IAlunosService service;

        public AlunosController(IAlunosService service)
        {
            this.service = service;
        }

        public IActionResult Index(/*string busca, bool ordenar = false*/)
        {
            //ViewBag.ordenar = ordenar;
            //Random r = new Random();

            return View(service.getAll(/*ordenar*/));
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Alunos alunos)
        {
            if (!ModelState.IsValid) return View(alunos);

            return service.create(alunos) ?
                RedirectToAction(nameof(Index)) :
                View(alunos);
        }


        public IActionResult Read(int? id)
        {
            Alunos alunos = service.get(id);
            return alunos != null ?
                View(alunos) :
                NotFound();
        }

        public IActionResult Update(int? id)
        {
            Alunos alunos = service.get(id);
            return alunos != null ?
                View(alunos) :
                NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Alunos alunos)
        {
            if (!ModelState.IsValid) return View(alunos);

            if (service.update(alunos))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(alunos);
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

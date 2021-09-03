using BlueDev.Models;
using BlueDev.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        ILinguagensService linguagensService;


        public AlunosController(IAlunosService service, ILinguagensService linguagensService)
        {
            this.linguagensService = linguagensService;
            this.service = service;
        }

        private void selectviewbag()
        {
            var linguagens = linguagensService.getAll();
            ViewBag.linguagens = new SelectList(linguagens, "Id", "Nome");
        }

        public IActionResult Index(/*string busca, bool ordenar = false*/)
        {
            //ViewBag.ordenar = ordenar;
            //Random r = new Random();

            return View(service.getAll(/*ordenar*/));
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            selectviewbag();
            return View();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Alunos alunos)
        {
            selectviewbag();

            if (!ModelState.IsValid) return View(alunos);

            return service.create(alunos) ?
                RedirectToAction(nameof(Index)) :
                View(alunos);
        }

        [Authorize]
        public IActionResult Read(int? id)
        {
            Alunos alunos = service.get(id);
            return alunos != null ?
                View(alunos) :
                NotFound();
        }

        [Authorize]
        public IActionResult Update(int? id)
        {
            var linguagens = linguagensService.getAll();
            ViewBag.listaDeLinguagens = new SelectList(linguagens, "Id", "Nome");
            Alunos alunos = service.getAll().FirstOrDefault(a => a.Id == id);
            return alunos != null ?
                View(alunos) :
                NotFound();
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Alunos alunos)
        {
            var linguagens = linguagensService.getAll();
            ViewBag.listaDeLinguagens = new SelectList(linguagens, "Id", "Nome");

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

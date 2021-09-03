using Consultorio.Models;
using Consultorio.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    //Controllers são responsáveis por trabalhar e buscar dados que serão utilizados para o usuário.
    public class PacienteController : Controller
    {
        IPacienteService service;

        public PacienteController(IPacienteService service)
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
        public IActionResult Create(Paciente paciente)
        {
            if (!ModelState.IsValid) return View(paciente);

            return service.create(paciente) ?
                RedirectToAction(nameof(Index)) :
                View(paciente);
        }


        public IActionResult Read(int? id) // localhost/Paciente/Read/id?
        {
            Paciente paciente = service.get(id);
            return paciente != null ?
                View(paciente) :
                NotFound();
        }

        public IActionResult Update(int? id)
        {
            Paciente paciente = service.get(id);
            return paciente != null ?
                View(paciente) :
                NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Paciente paciente)
        {
            if (!ModelState.IsValid) return View(paciente);

            if (service.update(paciente)) //// PacienteStaticService.Create(paciente)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(paciente);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (service.delete(id)) //// PacienteStaticService.Create(paciente)
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

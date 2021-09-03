using Consultorio.Models;
using Consultorio.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    //Controllers são responsáveis por trabalhar e buscar dados que serão utilizados para o usuário.
    public class ConsultaController : Controller
    {
        IConsultaService service;
        IPacienteService pacienteService;

        public ConsultaController(IConsultaService service, IPacienteService pacienteService)
        {
            this.service = service;
            this.pacienteService = pacienteService;
        }

        public IActionResult Index()
        {
            return View(service.getAll());
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            var pacientes = pacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Consulta consulta)
        {
            var pacientes = pacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");

            if (!ModelState.IsValid) return View(consulta);

            if (service.create(consulta))
                return RedirectToAction(nameof(Index));
            else {
                return View(consulta);
            }
        }

        [Authorize]
        public IActionResult Read(int? id) // localhost/Paciente/Read/id?
        {
            Consulta consulta = service.get(id);
            return consulta != null ?
                View(consulta) :
                NotFound();
        }

        [Authorize]
        public IActionResult Update(int? id)
        {
            var pacientes = pacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");
            Consulta consulta = service.get(id);
            return consulta != null ?
                View(consulta) :
                NotFound();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Consulta consulta)
        {
            var pacientes = pacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");
            if (!ModelState.IsValid) return View(consulta);

            if (service.update(consulta)) //// PacienteStaticService.Create(paciente)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(consulta);
            }
        }

        [Authorize]
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

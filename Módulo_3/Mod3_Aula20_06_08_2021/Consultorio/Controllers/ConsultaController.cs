using Consultorio.Models;
using Consultorio.Services;
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
        IPacienteService PacienteService;

        public ConsultaController(IConsultaService service, IPacienteService pacienteService)
        {
            this.service = service;
            this.PacienteService = pacienteService;
                 //this.PacienteService = PacienteService
        }


        //var datasOrdemCrescente = datas.OrderBy(c => Convert.ToDateTime(c));

        public IActionResult Index(/*bool ordenar = false*/)
        {
            //ViewBag.ordenar = ordenar;
            //Random r = datas.OrderBy(c => Convert.ToDateTime(c));
            return View(service.getAll(/*ordenar*/));
        }

        [HttpGet]
        public IActionResult Create()
        {
            var pacientes = PacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Consulta consulta)
        {
            var pacientes = PacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");

            if (!ModelState.IsValid) return View(consulta);

            if (service.create(consulta))
                return RedirectToAction(nameof(Index));

            else
            {
                return View(consulta);  
            }
        }


        public IActionResult Read(int? id) // localhost/Consulta/Read/id?
        {
            Consulta consulta = service.get(id);
            return consulta != null ?
                View(consulta) :
                NotFound();
        }

        public IActionResult Update(int? id)
        {
            var pacientes = PacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");

            Consulta consulta = service.get(id);
            return consulta != null ?
                View(consulta) :
                NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Consulta consulta)
        {
            var pacientes = PacienteService.getAll();
            ViewBag.listaDePacientes = new SelectList(pacientes, "Id", "Nome");

            if (!ModelState.IsValid) return View(consulta);

            if (service.update(consulta)) 
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(consulta);
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

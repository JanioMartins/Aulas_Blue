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
        //PacienteController p =  new PacienteController(new PacienteStaticService())
        //p.Index();

        IPacienteService service;
        public PacienteController(IPacienteService service)
        {
            this.service = service;
        }

        public IActionResult Index(string busca, bool ordenar = false)
        {
            ViewBag.ordenar = ordenar;
            return View(service.getAll(busca, ordenar)); // PacienteStaticService.getAll()
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            if (service.create(paciente)) //// PacienteStaticService.Create(paciente)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(paciente);
            }
            
        }

        //public IActionResult Read(int? id) // localhost/Paciente/Read/id?
        //{
        //    Paciente paciente = getPacientes().FirstOrDefault(p => p.Id == id);
        //    return paciente != null ? 
        //        View(paciente) :
        //        RedirectToAction(nameof(Index));
        //}

        //public IActionResult Update(int? id)
        //{
        //    Paciente paciente = getPacientes().FirstOrDefault(p => p.Id == id);
        //    return paciente != null ?
        //        View(paciente) :
        //        RedirectToAction(nameof(Index));
        //}
        
        //[HttpPost] 
        //public IActionResult Update(Paciente pacienteAtualizado)
        //{
        //    List<Paciente> listaPacientes = getPacientes();
        //    //p3
        //    Paciente pacienteExistente = listaPacientes.FirstOrDefault(p => p.Id == pacienteAtualizado.Id);
        //    if (pacienteExistente == null) return RedirectToAction(nameof(Index));


        //    // { p1, p2, p3}
        //    int indice = listaPacientes.IndexOf(pacienteExistente);

        //    //listaPaciente[2] = pacienteAtualizado
        //    listaPacientes[indice] = pacienteAtualizado;

        //    return View(nameof(Index), listaPacientes);
        //}

        //public IActionResult Delete(int? id)
        //{
        //    List<Paciente> lista = getPacientes();
        //    Paciente paciente = lista.FirstOrDefault(p => p.Id == id);
        //    if(paciente != null)
        //    {
        //        lista.Remove(paciente);
        //        return View(nameof(Index), lista);
        //    }

        //    return NotFound();
        //}

        
    }
}

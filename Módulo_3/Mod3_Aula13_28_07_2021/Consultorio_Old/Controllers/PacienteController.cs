using Consultorio.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    public class PacienteController : Controller
    {
        //public IActionResult Index(int? id) // Pacientes/Index/asadasd
        public IActionResult Index() // Pacientes/Index/asadasd
        {
            //ViewBag.lista = id == null ? getPacientes() : getPacientes().FindAll(paciente => paciente.Id == id);
            //List<Paciente> pacientes = id == null ? getPacientes() : getPacientes().FindAll(paciente => paciente.Id == id);
            //return View(pacientes);

            return View(getPacientes());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            List<Paciente> pacientes = getPacientes();
            paciente.Id = pacientes.Count() + 1;
            pacientes.Add(paciente);
            //ViewBag.lista = pacientes;
            return View("Index",pacientes);
        }

        List<Paciente> getPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            listaPacientes.Add(new Paciente { Id = 1, Nome = "Italo", Nascimento = new DateTime(1980,10,08) });
            listaPacientes.Add(new Paciente { Id = 2, Nome = "Eduardo", Nascimento = new DateTime(1995, 01, 25) });
            listaPacientes.Add(new Paciente { Id = 3, Nome = "Janio", Nascimento = new DateTime(2000, 7, 5) });
            return listaPacientes;
        }
    }
}

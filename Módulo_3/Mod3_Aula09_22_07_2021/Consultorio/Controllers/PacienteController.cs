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


        public IActionResult Index(int id) // Pacientes/Index/3
        {
            //List<Paciente> TodosPacientes = getPacientes();
            //List<Paciente> pacientesFiltrados = new List<Paciente>();

            //foreach (Paciente p in TodosPacientes)
            //{
            //    if(p.Id == id)
            //    {
            //        pacientesFiltrados.Add(p);
            //    }
            //}
            //ViewBag.lista = id == 0 ? TodosPacientes : pacientesFiltrados;

            //Exemplo 2
            //List<Paciente> TodosPacientes = getPacientes();
            //ViewBag.lista = id == 0 ? TodosPacientes : TodosPacientes.FindAll(x => x.Id == id);

            //ViewBag.lista = id == 0 ? getPacientes() : getPacientes().FindAll(x => x.Id == id);
            return View(id == 0 ? getPacientes() : getPacientes().FindAll(x => x.Id == id));
        }

        public IActionResult Create(Paciente)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paciente paciente)
        {
            List<Paciente> pacientes = getPacientes();
            paciente.Id = pacientes.Count() + 1;
            pacientes.Add(paciente);
            return View("Index", pacientes);
            //return Ok("O nome é: " + paciente.Nome);
        }


        List<Paciente> getPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            listaPacientes.Add(new Paciente { Id = 1, Nome = "Italo", });
            listaPacientes.Add(new Paciente { Id = 2, Nome = "Eduardo" });
            listaPacientes.Add(new Paciente { Id = 3, Nome = "Janio" });
            return listaPacientes;
        }
    }
}

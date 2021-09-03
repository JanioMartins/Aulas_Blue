using Linguagens;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Controllers
{
    public class BlueDevController : Controller
    {
        public IActionResult Index(string busca, bool ordenar = false)
        {
            ViewBag.ordenar = ordenar;
            // p2, p1 , p3 , p4
            if (ordenar)
            {
                var lista = getLinguagens();
                //lista.Sort((pa,pb) => pa.Nome.CompareTo(pb.Nome));
                lista = lista.OrderBy(p => p.Nome).ToList();
                return View(lista);
            }
            //List<Paciente> lista = getPacientes(); // nova lista
            //Paciente p = lista.First(); // nova lista
            //p.Nome = "teste";

            //return Ok(lista);




            if (getLinguagens().Count == 0) { 
                return RedirectToAction(nameof(Create));
            }

            return View(busca != null ? 
                getLinguagens().FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                ) : 
                getLinguagens());
        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Linguagens linguagem)
        //{
        //    List<Linguagens> linguagem = getLinguagens();
        //    paciente.Id = linguagem.Count() + 1;
        //    linguagem.Add(linguagem);
        //    //ViewBag.lista = pacientes;
        //    return View("Index",linguagem);
        //}

        //private List<Linguagens> getLinguagens()
        //{
        //    throw new NotImplementedException();
        //}

        //public IActionResult Read(int? id) // localhost/Paciente/Read/id?
        //{
        //    Linguagens paciente = getLinguagens().FirstOrDefault(p => p.Id == id);
        //    return paciente != null ? 
        //        View(paciente) :
        //        RedirectToAction(nameof(Index));
        //}

        //public IActionResult Update(int? id)
        //{
        //    Linguagens paciente = getLinguagens().FirstOrDefault(p => p.Id == id);
        //    return paciente != null ?
        //        View(paciente) :
        //        RedirectToAction(nameof(Index));
        //}

        //[HttpPost] 
        //public IActionResult Update(Linguagens pacienteAtualizado)
        //{
        //    List<Linguagens> listaPacientes = getLinguagens();
        //    //p3
        //    Linguagens pacienteExistente = listaPacientes.FirstOrDefault(p => p.Id == pacienteAtualizado.Id);
        //    if (pacienteExistente == null) return RedirectToAction(nameof(Index));


        //    // { p1, p2, p3}
        //    int indice = listaPacientes.IndexOf(pacienteExistente);

        //    //listaPaciente[2] = pacienteAtualizado
        //    listaPacientes[indice] = pacienteAtualizado;

        //    return View(nameof(Index), listaPacientes);
        //}

        //public IActionResult Delete(int? id)
        //{
        //    List<Linguagens> lista = getLinguagens();
        //    Linguagens paciente = lista.FirstOrDefault(p => p.Id == id);
        //    if(paciente != null)
        //    {
        //        lista.Remove(paciente);
        //        return View(nameof(Index), lista);
        //    }

        //    return NotFound();
        //}

        //List<Linguagens> getLinguagens()
        //{
        //    List<Linguagens> listaPacientes = new List<Linguagens>();
        //    listaPacientes.Add(new Linguagens { Id = 1, Nome = "Italo", Nascimento = new DateTime(1980,10,08), Descricao = "Paciente 1 - Italo"});
        //    listaPacientes.Add(new Linguagens { Id = 2, Nome = "Eduardo", Nascimento = new DateTime(1995, 01, 25), Descricao = "Paciente 2 - Eduardo" });
        //    listaPacientes.Add(new Linguagens { Id = 3, Nome = "Janio", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 3 - Janio" });
        //    listaPacientes.Add(new Linguagens { Id = 4, Nome = "Filipe", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 4 - Filipe" });
        //    listaPacientes.Add(new Linguagens { Id = 5, Nome = "Gabriel", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 5 - Gabriel" });
        //    return listaPacientes;
        //}
    }
}

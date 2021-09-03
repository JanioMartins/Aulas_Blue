using Consultorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Services
{
    //Responsável por buscar os dados de paciente na lista estática getPacientes()
    public class PacienteStaticService : IPacienteService
    {
        List<Paciente> getPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            listaPacientes.Add(new Paciente { Id = 1, Nome = "Italo", Nascimento = new DateTime(1980, 10, 08), Descricao = "Paciente 1 - Italo" });
            listaPacientes.Add(new Paciente { Id = 2, Nome = "Eduardo", Nascimento = new DateTime(1995, 01, 25), Descricao = "Paciente 2 - Eduardo" });
            listaPacientes.Add(new Paciente { Id = 3, Nome = "Janio", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 3 - Janio" });
            listaPacientes.Add(new Paciente { Id = 4, Nome = "Filipe", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 4 - Filipe" });
            listaPacientes.Add(new Paciente { Id = 5, Nome = "Gabriel", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 5 - Gabriel" });
            return listaPacientes;
        }

        public List<Paciente> getAll(string busca = null, bool ord = false)
        {
            if(busca != null)
            {
                return getPacientes().FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                );
            }

            if (ord)
            {
                var lista = getPacientes();
                //lista.Sort((pa,pb) => pa.Nome.CompareTo(pb.Nome));
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return getPacientes();
        }
        public bool create(Paciente paciente)
        {
            
            try {
                List<Paciente> pacientes = getPacientes();
                paciente.Id = pacientes.Count() + 1;
                pacientes.Add(paciente);
                return true;
            } 
            catch
            {
                return false;
            }
        }
        public Paciente get(int id)
        {
            return getPacientes().FirstOrDefault(p => p.Id == id);
        }

        public bool update(Paciente p)
        {
            return false;
        }

        public bool delete(int id)
        {
            return false;
        }
    }
}

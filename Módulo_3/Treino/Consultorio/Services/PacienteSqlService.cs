using Consultorio.Data;
using Consultorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Services
{
    //Responsável por buscar os dados de paciente no banco de dados com o uso do contexto
    public class PacienteSqlService : IPacienteService
    {
        ConsultorioContext context;
        public PacienteSqlService(ConsultorioContext context)
        {
            this.context = context;
        }

        public List<Paciente> getAll(string busca = null, bool ord = false)
        {
            List<Paciente> lista = context.Paciente.ToList();
            if (busca != null)
            {
                return lista.FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                );
            }

            if (ord)
            {
                //lista.Sort((pa,pb) => pa.Nome.CompareTo(pb.Nome));
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return lista;
        }
        public bool create(Paciente paciente)
        {
            try
            {
                context.Paciente.Add(paciente);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Paciente get(int? id)
        {
            return context.Paciente.Find(id);
        }

        public bool update(Paciente p)
        {
            try
            {
                context.Paciente.Update(p);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(int? id)
        {
            try { 
                context.Paciente.Remove(get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

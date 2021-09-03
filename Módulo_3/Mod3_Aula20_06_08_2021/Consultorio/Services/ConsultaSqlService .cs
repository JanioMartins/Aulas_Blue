using Consultorio.Data;
using Consultorio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Services
{
    //Responsável por buscar os dados de paciente no banco de dados com o uso do contexto
    public class ConsultaSqlService : IConsultaService
    {
        ConsultorioContext context;
        public ConsultaSqlService(ConsultorioContext context)
        {
            this.context = context;
        }

        public List<Consulta> getAll()
        {
            return context.Consulta.Include(c => c.paciente).ToList();
        }

        public bool create(Consulta consulta)
        {
            try
            {
                context.Consulta.Add(consulta);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Consulta get(int? id)
        {
            return context.Consulta.Include(c => c.paciente).FirstOrDefault(c => c.Id == id);
        }

        public bool update(Consulta c)
        {
            try
            {
                context.Consulta.Update(c);
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
            try
            {
                context.Consulta.Remove(get(id));
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

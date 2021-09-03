using BlueDev.Data;
using System.Collections.Generic;
using System.Linq;
using BlueDev.Models;
using Microsoft.EntityFrameworkCore;

namespace BlueDev.Services
{
    //Responsável por buscar os dados de paciente no banco de dados com o uso do contexto
    public class AlunosSqlService : IAlunosService
    {
        BlueDevContext context;
        public AlunosSqlService(BlueDevContext context)
        {
            this.context = context;
        }
        public List<Alunos> getAll()
        {
            return context.Alunos.Include(a => a.linguagens).ToList();
        }
        public bool create(Alunos alunos)
        {
            try
            {
                context.Alunos.Add(alunos);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Alunos get(int? id)
        {
            return context.Alunos.Include(a => a.linguagens).FirstOrDefault(a => a.Id == id);
        }

        public bool update(Alunos a)
        {
            try
            {
                context.Alunos.Update(a);
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
                context.Alunos.Remove(get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

       // public bool Create(Alunos alunos)
       // {
       //     throw new System.NotImplementedException();
       // }

       // Alunos IAlunosService.get(int? id)
       // {
       //     throw new System.NotImplementedException();
       // }
       //public bool Update(Alunos c)
       // {
       //     throw new System.NotImplementedException();
       // }
    }
}


using BlueDev.Data;
using BlueDev.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Services
{
    //Responsável por buscar os dados de Linguagens no banco de dados com o uso do contexto
    public class LinguagensSqlService : ILinguagensService
    {
        BlueDevContext context;
        public LinguagensSqlService(BlueDevContext context)
        {
            this.context = context;
        }

        public List<Linguagens> getAll(string busca = null, bool ord = false)
        {
            List<Linguagens> lista = context.Linguagens.Include(l => l.Alunos).ToList();
            if (busca != null)
            {
                return lista.FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                );
            }

            if (ord)
            {
                lista.Sort((pa,pb) => pa.Nome.CompareTo(pb.Nome));
                lista = lista.OrderBy(l => l.Lancamento).ToList();
                return lista;
            }
           return lista;
        }
        public bool create(Linguagens linguagens)
        {
            try
            {
                context.Linguagens.Add(linguagens);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Linguagens get(int? id)
        {
            return context.Linguagens.Include(l => l.Alunos).FirstOrDefault(l => l.Id == id);
        }

        public bool update(Linguagens linguagens)
        {
            try
            {
                context.Linguagens.Update(linguagens);
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
                context.Linguagens.Remove(get(id));
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

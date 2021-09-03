using BlueRuhe.Data;
using BlueRuhe.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueRuhe.Services
{
    public class ProdutosService : IProdutosService
    {

        BRContext _context;

        public ProdutosService(BRContext context)
        {
            _context = context;
        }

                public List<Produtos> All()
        {
            return _context.Produtos.ToList();
        }

        public bool Create(Produtos p)
        {
            try
            {
                p.created = DateTime.Now;
                _context.Add(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            if (!_context.Produtos.Any(p => p.Id == id))
                throw new Exception("Produto não existe!");

            try
            {
                _context.Produtos.Remove(this.Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Produtos Get(int? id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Produtos p)
        {
            try
            {
                if (!_context.Produtos.Any(p => p.Id == p.Id)) throw new Exception("Produto não existe!");

                p.updated = DateTime.Now;
                _context.Update(p);
                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public List<Produtos> ProdutosByUserRole(string getRole)
        {
            var lquery1 = from produtos in _context.Set<Produtos>()
                          join user in _context.Set<IdentityUser>()
                            on produtos.createdById equals user.Id
                          join userRoles in _context.Set<IdentityUserRole<string>>()
                            on user.Id equals userRoles.UserId
                          join role in _context.Set<IdentityRole>()
                            on userRoles.RoleId equals role.Id
                          where role.Name.ToUpper() == getRole
                          select new Produtos()
                          {
                              Id = produtos.Id,
                              Descricao = produtos.Descricao,
                              Tipo = produtos.Tipo,
                              Tamanho = produtos.Tamanho,
                              Cor = produtos.Cor,
                              Estoque = produtos.Estoque,
                              Preco = produtos.Preco,
                              created = produtos.created,
                              updated = produtos.updated,
                              createdBy = produtos.createdBy,
                              updatedBy = produtos.updatedBy
                          };


            return lquery1.ToList();
        }

    }
}

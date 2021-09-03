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
                _context.Produtos.Add(p);
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

        public bool Update(Produtos p, string user)
        {
                try
                {
                    if (!_context.Produtos.Any(p => p.Id == p.Id)) throw new Exception("Produto não existe!");

                    p.UpdatedBy = user;
                    p.CreatedBy = _context.Produtos.AsNoTracking().FirstOrDefault(p => p.Id == p.Id).CreatedBy;
                    _context.Update(p);
                    _context.SaveChanges();
                    return true;

                }
                catch
                {
                    return false;
                }

        }
    }
}

using BlueRuhe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueRuhe.Services
{
    public interface IProdutosService
    {

        List<Produtos> All();
        Produtos Get(int? id);
        bool Create(Produtos p);
        bool Update(Produtos p, string user);
        bool Delete(int? id);

    }
}

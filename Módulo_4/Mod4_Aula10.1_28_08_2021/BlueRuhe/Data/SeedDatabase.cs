using BlueRuhe.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueRuhe.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BRContext(
                serviceProvider.GetRequiredService<DbContextOptions<BRContext>>()))
            {
                if (context.Produtos.Any())
                {
                    return;
                }

                context.Produtos.Add(new Produtos { Descricao = "CAMISETA TOMMY", Tipo = "ESTAMPADA", Tamanho = "GG", Cor = "PRETA", Estoque = 35, Preco = 300, CreatedBy = "SYSTEM", UpdatedBy = "SYSTEM"});
                context.Produtos.Add(new Produtos { Descricao = "CAMISETA LACOSTE", Tipo = "ESTAMPADA", Tamanho = "G", Cor = "BRANCA", Estoque = 15, Preco = 380, CreatedBy = "SYSTEM", UpdatedBy = "SYSTEM"});
                context.Produtos.Add(new Produtos { Descricao = "CAMISETA ARMANY", Tipo = "LISA", Tamanho = "M", Cor = "PRETA", Estoque = 27, Preco = 200, CreatedBy = "SYSTEM", UpdatedBy = "SYSTEM" });
                context.Produtos.Add(new Produtos { Descricao = "CAMISETA HUGO BOSS", Tipo = "ESTAMPADA", Tamanho = "M", Cor = "PRETA", Estoque = 10, Preco = 320, CreatedBy = "SYSTEM", UpdatedBy = "SYSTEM" });
                context.Produtos.Add(new Produtos { Descricao = "CAMISETA GUCCI", Tipo = "LISA", Tamanho = "GG", Cor = "PRETA", Estoque = 8, Preco = 100, CreatedBy = "SYSTEM", UpdatedBy = "SYSTEM" });
                context.Produtos.Add(new Produtos { Descricao = "CAMISETA LACOSTE", Tipo = "LISA", Tamanho = "G", Cor = "PRETA", Estoque = 5, Preco = 430, CreatedBy = "SYSTEM", UpdatedBy = "SYSTEM" });

                context.SaveChanges();
            }
        }
    }
}

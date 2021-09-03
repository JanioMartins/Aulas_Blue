using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    public class Produto
    {
        private double _preco;
        public string Nome { get; set; }
#pragma warning disable CA2011 // Evitar a recursão infinita
        public double Preco { get => _preco; set => Preco = value > 0 ? value = 0; }
#pragma warning restore CA2011 // Evitar a recursão infinita

        public string Descricao { get => $"Nome: {Nome} - Preco: {Preco:0.00}"; }
    }
  
}

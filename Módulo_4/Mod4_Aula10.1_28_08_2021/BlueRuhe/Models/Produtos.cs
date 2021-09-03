using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueRuhe.Model
{
    public class Produtos
    {

        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Tipo { get; set; }

        public string Tamanho { get; set; }

        public string Cor { get; set; }

        public int Estoque { get; set; }

        public double Preco { get; set; }

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }


    }
}

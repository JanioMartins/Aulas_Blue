using Microsoft.AspNetCore.Identity;
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

        public DateTime? created { get; set; }
        public DateTime? updated { get; set; }
        public string updatedById { get; set; }
        public IdentityUser updatedBy { get; set; }
        public string createdById { get; set; }
        public IdentityUser createdBy { get; set; }

    }
}

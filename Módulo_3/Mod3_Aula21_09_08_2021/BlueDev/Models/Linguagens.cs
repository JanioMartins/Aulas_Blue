using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Models
{
    public class Linguagens
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Aplicacao { get; set; }

        public DateTime Lancamento { get; set; }

        public string Desenvolvedor { get; set; }
        public string Logo { get; set; }

        public List<Alunos> Alunos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Models
{
    public class Linguagens
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe um nome!")]
        [Display(Name = "Nome")]
        public string Nome { get; set;}

        //[Required(ErrorMessage = "Informe a Aplicação!")]
        [Display(Name = "Aplicacao")]
        public string Aplicacao { get; set; }

        //[Required(ErrorMessage = "Informe a Data de Lançamento!")]
        [Display(Name = "Lancamento")]
        public DateTime Lancamento { get; set; }

        //[Required(ErrorMessage = "Informe o Desenvolvedor!")]
        [Display(Name = "Desenvolvedor")]
        public string Desenvolvedor { get; set; }

        [Required(ErrorMessage = "Insira uma imagem!")]
        [Display(Name = "Logo")]
        public string Logo { get; set; }

        [Required(ErrorMessage = "Informe um Aluno!")]
        [Display(Name = "Alunos")]
        public List<Alunos> Alunos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Paciente
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime? Nascimento { get; set; }


        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}

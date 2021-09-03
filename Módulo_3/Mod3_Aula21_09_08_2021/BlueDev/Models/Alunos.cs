using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Models
{
    public class Alunos
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public int? linguagensId { get; set; }

        public List<Linguagens> linguagens { get; set; }
        
    }
}

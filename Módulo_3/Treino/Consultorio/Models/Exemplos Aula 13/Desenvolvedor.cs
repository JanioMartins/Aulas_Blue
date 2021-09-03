using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome) : base(nome)
        {
            this.nome = "Dev " + nome;
        }
        public override double plr { get => salario * 10; }

        public double valorHoraExtra { get => 100; }
    }
}

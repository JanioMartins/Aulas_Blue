using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models
{
    public class Gerente : Funcionario, IFuncionarioFinanceiro
    {

        // nome = "Hyago"
        public Gerente(string x) : base(x)
        {
            this.nome = "Ger " + x;

            string teste = GerarHoleriteFuncionario();
        }
        public override int FeriasAnuais { get => 60; }

        public override double plr { get => salario * 20; }

        public double custoAnual()
        {
            return plr + (salario * 12);
        }
    }
}

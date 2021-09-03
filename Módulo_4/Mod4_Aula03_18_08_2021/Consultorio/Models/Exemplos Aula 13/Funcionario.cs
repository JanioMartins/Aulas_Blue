namespace Consultorio.Models
{
    public abstract class Funcionario
    {
        public Funcionario(string nome)
        {
            this.nome = nome;
        }

        public string GerarHoleriteFuncionario()
        {
            return "ok";
        }


        public string nome { get; set; }
        public double salario { get; set; }
        public abstract double plr { get; }
        public virtual int FeriasAnuais { get => 30; }
    }
}

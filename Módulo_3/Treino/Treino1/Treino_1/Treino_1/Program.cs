using System;

namespace Treino_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Condicao;

            Console.WriteLine("Hello World!");
            Console.WriteLine("How are you ?");

            Condicao = Console.ReadLine();
            Console.WriteLine("Condição: " + Condicao);

           

            string resultado;

            
            Console.WriteLine("1° Número: ");
            Console.WriteLine("Operador: ");
            Console.WriteLine("2° Número: ");

            resultado = Console.ReadLine();
            Console.WriteLine("Resultado = " + resultado);

            Console.ReadKey();

        }
    }
}

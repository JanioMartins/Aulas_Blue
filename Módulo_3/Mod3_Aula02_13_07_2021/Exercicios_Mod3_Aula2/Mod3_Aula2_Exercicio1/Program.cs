using System;




// 1. Algoritmo para calcular fatorial de um número informado pelo usuário.

//* Linha que Indica o Título do projeto -
//Usamos para organização e para uma tela conversar com a outra.*
namespace Mod3_Aula2_Exercicio1
{
    //* Linha que indica a classe (Objeto) Program.*
    class Program
    {
        //* Linha que indica a tela "Main" (Tela principal do programa).*
        static void Main(string[] args) 
        {
            //* Linha para capturar um número digitado pelo usuário.*
            Console.WriteLine("Digite um número para calcular o seu fatorial: ");

            //* Armazena o número digitado pelo usário e mostra na tela.*
            int numero = Convert.ToInt32(Console.ReadLine());
            int fatorial = 1;

            //* Laços de Repetição*
            for (int i = 1; i <= numero; i++)
            {
                fatorial = fatorial * i;
            }

            //* Contador para mostrar quantas operações são necessárias
            //para se obter o resulta final.*
            int quant = numero - 1;

            //* Bloco para Imprimir ao usuário o resultado da operação.*
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"Número escolhido___________:  {numero} ");
            Console.WriteLine($"Quantidade de operações____:  {quant} ");
            Console.WriteLine($"Resultado__________________:  {fatorial} ");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");


        }
    }
}

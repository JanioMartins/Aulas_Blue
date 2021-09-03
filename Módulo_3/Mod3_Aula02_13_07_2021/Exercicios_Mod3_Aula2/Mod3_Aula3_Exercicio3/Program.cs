
//* 3.Algoritmo para definir um array de números com tamanho e valores
//definidos pelo usuário e apresentá-lo em tela ordenado de forma
//crescente.*


using System;
using System.Collections.Generic;
using System.Linq;

//* Linha que Indica o Título do projeto -
//Usamos para organização e para uma tela conversar com a outra.*
namespace Mod3_Aula3_Exercicio3
{
    //* Linha que indica a classe (Objeto) Program.*
    class Program
    {
        //* Linha que indica a tela "Main" (Tela principal do programa).*
        static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            //* Linha para capturar os Valores digitados pelo usuário.*
            Console.WriteLine("Quantos valores você deseja adicionar ao array? ");
            //* Armazena os valores digitados pelo usário e mostra na tela.*
            int quant = Convert.ToInt32(Console.ReadLine());
            int[] values = new int[quant]; // CRIAR UM ARRAY VAZIO DE TAMANHO FIXO!
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            int contador = 0;

            //* Laços de Repetição com o número de repetição definido pelo usuário*
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Adicione o {i + 1}º valor: ");
                values[i] = Convert.ToInt32(Console.ReadLine());

                contador += 1;
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            //// ORDENAR A LISTA

            Array.Sort(values);
            Console.WriteLine($"Quantidade de valores_____: {contador}");
            Console.WriteLine("Resultado_________________: [{0}] {1}", string.Join(", ", values), "");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}

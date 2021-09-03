
//* 2. Algoritmo para encontrar o maior valor de uma lista de números com
//tamanho e valores definidos por usuário.*

using System;
using System.Collections.Generic;
using System.Linq;



//* Linha que Indica o Título do projeto -
//Usamos para organização e para uma tela conversar com a outra.*
namespace Mod3_Aula2_Exercicio2
{
    //* Linha que indica a classe (Objeto) Program.*
    class Program
    {
        //* Linha que indica a tela "Main" (Tela principal do programa).*
        static void Main(string[] args)
        {
            //* Linha para capturar valores digitados pelo usuário.*
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            //* Armazena os valores digitados pelo usário e mostra na tela.*
            Console.WriteLine("Quantos valores você deseja adiconar à lista? ");
            int quant = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            
            int contador = 0;
            int[] values = new int[quant];

            //* Laços de Repetição com o número de repetição definido pelo usuário*
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Adicione o {i + 1}º valor: ");
                values[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                contador += 1;
            }

            //*Captura do maior número da lista*
            int n = values.Max();
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"Quantidade de valores____: {contador}");
            Console.WriteLine("Valores Escolhidos_______: [{0}]", string.Join(", ", values));
            Console.WriteLine($"Maior Valor______________: {n:0.00}.");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}

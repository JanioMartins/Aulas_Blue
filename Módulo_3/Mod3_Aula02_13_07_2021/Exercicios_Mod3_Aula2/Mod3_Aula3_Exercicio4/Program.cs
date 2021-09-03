


//* 4. Altere o algoritmo anterior para que os números sejam inseridos no
//array aleatoriamente: utilizar o objeto Random(). A aplicação também
//deve apresentar o número que tem a maior frequência.*/


using System;
using System.Collections.Generic;
using System.Linq;

//* Linha que Indica o Título do projeto -
//Usamos para organização e para uma tela conversar com a outra.*

namespace Mod3_Aula3_Exercicio4
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

            Random aleatorio = new Random(); // INSTANCIANDO OBJETO DO TIPO Random

            int v_recor = 0;
            int contador = 0;

            //* Laços de Repetição com o número de repetição definido pelo usuário*
            for (int i = 0; i < quant; i++)
            {

                // .Next(inicio, fim) -> traz o PRÓXIMO valor aleatório
                values[i] = aleatorio.Next(1, 100);
                if (i = i)
                {
                    v_recor += 1;
                }

                contador += 1;
            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            //// ORDENAR A LISTA

            Array.Sort(values);
            Console.WriteLine($"Quantidade de valores_____: {contador}");
            Console.WriteLine("Resultado_________________: [{0}] {1}", string.Join(", ", values), "");
            Console.WriteLine($"Valor recorrente__________: {v_recor}");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

// 1. Algoritmo para calcular fatorial de um número informado pelo usuário.
//Console.WriteLine("Digite o número para calcular o seu fatorial: ");
//int numero = Convert.ToInt32(Console.ReadLine());
//int fatorial = 1;

//for (int i = 1; i <= numero; i++)
//{
//    fatorial = fatorial * i;
//    Console.WriteLine(fatorial);
//}

//Console.WriteLine($"O fatorial de {numero} é {fatorial}.");



// 2. Algoritmo para encontrar o maior valor de uma lista de números 
//    com tamanho e valores definidos por usuário.
//Console.WriteLine("Quantos valores você deseja adiconar à lista? ");
//int quant = Convert.ToInt32(Console.ReadLine());
//int[] values = new int[quant];

//for (int i = 0; i < quant; i++)
//{
//    Console.WriteLine($"Adicione o {i + 1}º valor: ");
//    values[i] = Convert.ToInt32(Console.ReadLine());
//}

//int n = values.Max();
//Console.WriteLine($"O maior valor digitado é {n:0.00}.");

//Console.WriteLine("[{0}]", string.Join(", ", values));


//Console.WriteLine("Quantos numeros você pretende adicionar: ");
//string entradaTamanho = Console.ReadLine();
//int tamanho = Int32.Parse(entradaTamanho);
//Console.WriteLine("Digite os valores que deseja adicionar: ");
//int contador = 0;
//List<int> valores = new List<int> { };
//while (contador <= tamanho)
//{
//    string entradaValores = Console.ReadLine();
//    int valor = Int32.Parse(entradaValores);
//    valores.Add(valor);
//    contador += 1;
//}
//Console.WriteLine("[{0}]", string.Join(", ", valores));







// Console.WriteLine("{0:F2}", 12); -> 12.00
// FORMATAR FLOAT DE UMA FORMA DIFERENTE!







//3. Algoritmo para definir um array de números com tamanho 
//   e valores definidos pelo usuário e apresentá-lo em tela ordenado de forma crescente.
//Console.WriteLine("Quantos valores você deseja adicionar ao array? ");
//int quant = Convert.ToInt32(Console.ReadLine());
//int[] values = new int[quant]; // CRIAR UM ARRAY VAZIO DE TAMANHO FIXO!

//for (int i = 0; i < quant; i++)
//{
//    Console.WriteLine($"Adicione o {i + 1}º valor: ");
//    values[i] = Convert.ToInt32(Console.ReadLine());
//}

//// ORDENAR A LISTA
//Array.Sort(values);

//Console.WriteLine("[{0}] {1}", string.Join(", ", values), " é a lista ordenada!");

//<2, 8, 16> -> passo 1
//2   8   16 -> passo 2
//"2"   "8"   "16" -> passo 3
//"2" + ", " + "8" + ", " + "16" -> passo 4
//"2, 8, 16" -> passo 5
//"[2, 8, 16] é a lista ordenada!"












//4. Altere o algoritmo anterior para que os números sejam inseridos no array aleatoriamente:
//   utilizar UM objeto DO TIPO Random().

//Console.WriteLine("Quantos valores você deseja adicionar ao array? ");
//int quant = Convert.ToInt32(Console.ReadLine());
//int[] values = new int[quant]; // CRIAR UM ARRAY VAZIO DE TAMANHO FIXO!

//Random aleatorio = new Random(); // INSTANCIANDO OBJETO DO TIPO Random

//for (int i = 0; i < quant; i++)
//{
//    values[i] = aleatorio.Next(1,100);  // .Next(inicio, fim) -> traz o PRÓXIMO valor aleatório
//}

//// ORDENAR A LISTA
//Array.Sort(values);

//Console.WriteLine("[{0}] {1}", string.Join(", ", values), " é a lista ordenada!");




////////////////////////////////////////////////////////////////////////////////////////////
// FUNÇÕES / MÉTODOS

//int eleva2(int x)
//{
//    int y = x * x;
//    return y;
//}

//void imprimir(int n=0, string palavra="NADA")
//{
//    Console.WriteLine($"O número é {n}");
//    Console.WriteLine($"A palavra é {palavra}");
//}

//Console.WriteLine(eleva2(7));
//imprimir();
//imprimir(12, "Dinossauro");
//imprimir(palavra: "Bicicleta", n: 6);


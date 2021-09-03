using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque
{
    public class BlueShop
    {
        List<Produto> produtos = new List<Produto>();

        public void Iniciar()
        {
            Console.WriteLine("Selecione uma opção; ");
            Console.WriteLine("1 - Cadastrar um produto; ");
            Console.WriteLine("2 - Listar os produtos;");
            Console.WriteLine("0 - Sair da aplicação;");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CadastroDeProdutos();
                    break;                
                case "2":
                    CadastroDePreco();
                    break;                
                case "0":
                    return;
                
                default:
                    Console.WriteLine("Opção Inválida!!!");
                    break;
            }

            Console.WriteLine("Pressione Alguma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Iniciar();

        }

        void CadastroDeProdutos()
        {
            Produto produto = new Produto();

            Console.WriteLine("Nome do produto: ");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Preço do produto: ");
            produto.Preco = Convert.ToDouble(Console.ReadLine());

            produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} Adicionado com Sucesso!!!");
        }

        void CadastroDePreco()
        {
            foreach (Produto p in produtos)
            {
                Console.WriteLine("=-=-");
                Console.WriteLine(p.Descricao);

            }
        }
    }
}

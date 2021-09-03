using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Jogo
    {
        Heroi heroi;

        public void Iniciar()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Nome do Jogador: ");
            heroi = new(Console.ReadLine());
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Menu();
        }

        void Menu()
        {
            Console.Clear();
            MostraInfo();

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("- Deseja Lutar contra qual Inimigo: ");
            Console.WriteLine(" 1 - Orc");
            Console.WriteLine(" 2 - Troll");
            Console.WriteLine(" 3 - Goblin");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Sair");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "Orc":
                    Batalhar(new Monstro("Orc", heroi.nivel * 2, heroi.nivel));
                    break;

                case "2":
                case "Troll":
                    Batalhar(new Monstro("Troll", heroi.nivel * 2, heroi.nivel));
                    break;

                case "3":
                case "Goblin":
                    Batalhar(new Monstro("Goblin", heroi.nivel * 2, heroi.nivel));
                    break;

                case "0":
                case "Sair":
                    return;

                default:
                    Console.WriteLine("Opção Inválida!!!");
                    break;

            }

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Continue... (Presione qualquer tecla)...");
            Console.ReadKey();
            if (heroi.vida <= 0)
            {
                Console.WriteLine("Game Over!...");
                return;
            }
            else
            {
                Menu();
            }
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");


            void Batalhar(Monstro monstro)
            {
                Console.Clear();
                MostraInfo();
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Monstro___________: {monstro.nome}");
                Console.WriteLine($"Ataque____________: {monstro.ataque}");
                Console.WriteLine($"Experiência_______: {monstro.xp}");
                Console.WriteLine($"Vida______________: {monstro.vida}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                Console.WriteLine("Lutar ou Recomeçar? ");
                Console.WriteLine(" 0 - Recomeçar");
                Console.WriteLine(" 1 - Lutar  ");

                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                    case "Lutar":
                        monstro.vida -= heroi.ataque;
                        Console.WriteLine($"Dano no {monstro.nome}_____: {heroi.ataque}");
                        heroi.vida -= monstro.ataque;
                        Console.WriteLine($"Dano no {heroi.nome}_______: {monstro.ataque}");
                        if (heroi.vida <= 0)
                        {
                            Console.WriteLine("Game Over!!!...");
                            return;
                        }
                        break;

                        if (monstro.vida <= 0)
                        {
                            Console.WriteLine("Vencedor!!!...");
                            Console.WriteLine($"Experiência Adquirida______: {monstro.xp}");
                            heroi.nxp(monstro.xp);

                            return;
                        }

                    case "0":
                    case "Recomeçar":
                        Console.WriteLine("Recomeçando...");
                        return;
                }

                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("Continue... (Presione qualquer tecla)...");
                Console.ReadKey();
                Batalhar(monstro);
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            }


            void MostraInfo()
            {
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"Herói____________: {heroi.nome}");
                Console.WriteLine($"Nivel____________: {heroi.nivel}");
                Console.WriteLine($"Experiência______: {heroi.xp}");
                Console.WriteLine($"Ataque Base______: {heroi.ab}");
                Console.WriteLine($"Atque____________: {heroi.ataque}");
                Console.WriteLine($"Vida_____________: {heroi.vida}");
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            }

        }
    }
}

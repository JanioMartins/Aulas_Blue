using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Heroi
    {
        public string nome { get; set; }
        public int ab { get; set; }
        public int ataque { get; set; }
        public int nivel { get; set; }
        public int xp { get; set; }
        public int vida { get; set; }

        public Heroi(string nome)
        {
            Random aleartorio = new Random();
            this.nome = nome;
            this.ab = aleartorio.Next(1, 11);
            this.ataque = this.ab;
            this.nivel = 1;
            this.xp = 0;
            this.vida = 10;
        }

        public void nxp(int experiencia)
        {
            xp += experiencia;
            int n_niv = (xp / 10) + 1;
            if (n_niv > nivel)
            {
                Console.WriteLine("Subindo o nível...");
                vida = n_niv * 10;
            }

            nivel = n_niv;
            ataque = ab + nivel;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MensagemFumaca : IMessage
    {
        public void Enviar(string mensagem)
        {
            Console.WriteLine("Fumaceando... "+ mensagem);
        }
    }
}

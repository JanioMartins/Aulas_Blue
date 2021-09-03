using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MensagemEmail : IMessage
    {
        public void Enviar(string msg)
        {
            Console.WriteLine("Email enviado com:" + msg);
        }
    }
}

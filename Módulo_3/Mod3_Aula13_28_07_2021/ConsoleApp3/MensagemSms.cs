using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MensagemSms : IMessage
    {
        public void Enviar(string msg)
        {
            Console.WriteLine("Mensagem sms enviada com o texto:" + msg);
        }
    }
}

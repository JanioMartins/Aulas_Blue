using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class App
    {
        IMessage m;
        public App(IMessage m)
        {
            this.m = m;
        }
        public void iniciar()
        {
            enviarMensagem("Mensagem 1");
            enviarMensagem("Mensagem 2");
            enviarMensagem("Mensagem 3");
        }

        public void enviarMensagem(string mensagem)
        {
            m.Enviar(mensagem);
        }
    }
}

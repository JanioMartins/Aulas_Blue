using BlueDev.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Controllers
{
    public class LinguagensController : Controller
    {
        public IActionResult Index()
        {
            return View(GetLinguagens());
        }

        List<Linguagens> GetLinguagens()
        {
            List<Linguagens> ListaLinguagens = new List<Linguagens>();
            ListaLinguagens.Add(new Linguagens { Id = 1, Nome= "C#", 
                Aplicacao= "C# (pronuncia-se "See Sharp") é uma linguagem de programação moderna, orientada a objeto e fortemente digitada. " +
                "O C# permite que os desenvolvedores criem muitos tipos de aplicativos seguros e robustos que são executados no ecossistema do .NET. " +
                "O C# tem suas raízes na família de linguagens C e os programadores em C, C++, Java e JavaScript a reconhecerão imediatamente. " +
                "Este tour fornece uma visão geral dos principais componentes da linguagem no C# 8 e anterior.", 
                Lancamento= new DateTime(1990, 01, 01), 
                Desenvolvedor= "Microsoft", 
                Logo= "https://growiz.com.br/wp-content/uploads/2020/08/kisspng-c-programming-language-logo-microsoft-visual-stud-atlas-portfolio-5b899192d7c600.1628571115357423548838.png" });

            ListaLinguagens.Add(new Linguagens { Id = 2, Nome= "Python", Aplicacao= "Criar aplicações Desktops e Web", Lancamento= new DateTime(1990, 01, 01), Desenvolvedor= "Microsoft", Logo=""});
            ListaLinguagens.Add(new Linguagens { Id = 3, Nome= "JavaScript", Aplicacao= "Criar aplicações Desktops e Web", Lancamento= new DateTime(1990, 01, 01), Desenvolvedor= "Microsoft", Logo=""});
            ListaLinguagens.Add(new Linguagens { Id = 4, Nome= "C++", Aplicacao= "Criar aplicações Desktops e Web", Lancamento= new DateTime(1990, 01, 01), Desenvolvedor= "Microsoft", Logo=""});
            ListaLinguagens.Add(new Linguagens { Id = 5, Nome= "Delphi", Aplicacao= "Criar aplicações Desktops e Web", Lancamento= new DateTime(1990, 01, 01), Desenvolvedor= "Microsoft", Logo=""});
            ListaLinguagens.Add(new Linguagens { Id = 6, Nome= "Cobol", Aplicacao= "Criar aplicações Desktops e Web", Lancamento= new DateTime(1990, 01, 01), Desenvolvedor= "Microsoft", Logo=""});
            ListaLinguagens.Add(new Linguagens { Id = 7, Nome= "Java", Aplicacao= "Criar aplicações Desktops e Web", Lancamento= new DateTime(1990, 01, 01), Desenvolvedor= "Microsoft", Logo=""});
            ListaLinguagens.Add(new Linguagens { Id = 8, Nome= "C", Aplicacao= "Criar aplicações Desktops e Web", Lancamento= new DateTime(1990, 01, 01), Desenvolvedor= "Microsoft", Logo=""});
            ListaLinguagens.Add(new Linguagens { Id = 9, Nome= "Pascal", Aplicacao= "Criar aplicações Desktops e Web", Lancamento= new DateTime(1990, 01, 01), Desenvolvedor= "Microsoft", Logo=""});
            ListaLinguagens.Add(new Linguagens { Id = 10, Nome= "ActionScript", Aplicacao= "Criar aplicações Desktops e Web", Lancamento= new DateTime(1990, 01, 01), Desenvolvedor= "Microsoft", Logo=""});
            

            return ListaLinguagens;
        }

    }
}

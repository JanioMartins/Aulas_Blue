using BlueDev.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Services
{
    //Responsável por buscar os dados de paciente na lista estática getPacientes()
    public class LinguagensStaticService : ILinguagensService
    {
        List<Linguagens> getLinguagens()
        {
            List<Linguagens> listaLinguagens = new List<Linguagens>();

            listaLinguagens.Add(new Linguagens
            {
                Id = 1,
                Nome = "C#",
                Aplicacao = "C# (pronuncia-se 'See Sharp') é uma linguagem de programação moderna, orientada a objeto e fortemente digitada. O C# permite que os desenvolvedores criem muitos tipos de aplicativos seguros e robustos que são executados no ecossistema do .NET. O C# tem suas raízes na família de linguagens C e os programadores em C, C++, Java e JavaScript a reconhecerão imediatamente. Este tour fornece uma visão geral dos principais componentes da linguagem no C# 8 e anterior.",
                Lancamento = new DateTime(2000),
                Desenvolvedor = "Anders Hejlsberg",
                Logo = "https://ivaldo.dev/wp-content/uploads/2019/03/27_c-sharp-logo-filled.png"
            });



            listaLinguagens.Add(new Linguagens
            {
                Id = 2,
                Nome = "Python",
                Aplicacao = "Python é uma linguagem de programação de alto nível, ou seja, com sintaxe mais simplificada e próxima da linguagem humana, utilizada nas mais diversas aplicações, como desktop, web, servidores e ciência de dados.",
                Lancamento = new DateTime(1991, 02, 20),
                Desenvolvedor = "Guido van Rossum",
                Logo = "https://lh3.googleusercontent.com/proxy/-hIth7N26d3-SvY23aNkHA83ez1AWoFEumc1P1Lr-lPBxaOZMn2H1I_V8hljAExf8yXuKnslZqYVv7jGCWMF1-gKCCKByKOd-F8JWuGoKoO4qa45_ZVK7w-kUtWRyuNs-qCY34j2pB33eyHw"
            });


            listaLinguagens.Add(new Linguagens
            {
                Id = 3,
                Nome = "JavaScript",
                Aplicacao = "JavaScript é uma linguagem de programação que permite implementar funcionalidades mais complexas em páginas web. Sempre que uma página web faz mais do que apenas mostrar informações estáticas para você - ela mostra em tempo real conteúdos atualizados, mapas interativos, animações gráficas em 2D/3D, vídeos, etc. -  você pode apostar que o Javascript provavelmente está envolvido.",
                Lancamento = new DateTime(1995, 12, 04),
                Desenvolvedor = "Brendan Eich",
                Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Unofficial_JavaScript_logo_2.svg/1200px-Unofficial_JavaScript_logo_2.svg.png"
            });


            listaLinguagens.Add(new Linguagens
            {
                Id = 5,
                Nome = "C++",
                Aplicacao = "O C++ é uma linguagem de programação de nível médio, baseada na linguagem C. O desenvolvimento da linguagem começou na década de 80, por Bjarne Stroustrup. O objetivo do desenvolvimento desta linguagem era melhorar uma versão do núcleo Unix. Para desenvolver a linguagem, foram acrecentados elementos de outras linguagens de vários níveis, na tentativa de criar uma linguagem com elementos novos, sem trazer problemas para a programação. No inicio do desenvolvimento, a linguagem usava um pré-processador, mais Stroustrup criou um compilador próprio, com novas caracteristicas.",
                Lancamento = new DateTime(1979),
                Desenvolvedor = "Bjarne Stroustrup",
                Logo = "https://www.alura.com.br/artigos/assets/formacao-linguagem-c-plus-plus/img-01.png"
            });


            listaLinguagens.Add(new Linguagens
            {
                Id = 6,
                Nome = "Delphi",
                Aplicacao = "O Delphi é uma plataforma completa para desenvolvimento de software, seja ele desktop, web ou mobile. Os pilares dessa tecnologia são a IDE, a linguagem e o compilador, todos batizados com o mesmo nome: Delphi. A partir desses três pilares é possível atender às principais necessidades do atual mercado de desenvolvimento de software.",
                Lancamento = new DateTime(1995),
                Desenvolvedor = "Anders Hejsberg",
                Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgrcB-q_MhlPhCjHjn0fZ0pc1D95nqZzhjOPrNZQqYmDesA77HY18S6e1IHkvLa8QIQ90&usqp=CAU"
            });


            return listaLinguagens;
        }

        public List<Linguagens> getAll(string busca = null, bool ord = false)
        {
            if(busca != null)
            {
                return getLinguagens().FindAll(a =>
                    a.Nome.ToLower().Contains(busca.ToLower())
                );
            }

            if (ord)
            {
                var lista = getLinguagens();
                //lista.Sort((pa,pb) => pa.Nome.CompareTo(pb.Nome));
                lista = lista.OrderBy(p => p.Nome).ToList();
                return lista;
            }
            return getLinguagens();
        }
        //public bool create(Linguagens linguagens)
        //{

        //    try
        //    {
        //        List<Linguagens> linguagens = getLinguagens();
        //        linguagens.Id = linguagens.Count() + 1;
        //        linguagens.Add(linguagens);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public Linguagens get(int? id)
        {
            return getLinguagens().FirstOrDefault(l => l.Id == id);
        }

        public bool update(Linguagens p)
        {
            return false;
        }

        public bool delete(int? id)
        {
            return false;
        }

        public bool create(Linguagens linguagens)
        {
            throw new NotImplementedException();
        }
    }
}

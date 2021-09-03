
using BlueDev.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace BlueDev.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IHost app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<BlueDevContext>();
                context.Database.Migrate(); // update-database

                if (!context.Linguagens.Any())

                {
                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "C#",
                        Aplicacao = "C# (pronuncia-se 'See Sharp') é uma linguagem de programação moderna, orientada a objeto e fortemente digitada. O C# permite que os desenvolvedores criem muitos tipos de aplicativos seguros e robustos que são executados no ecossistema do .NET. O C# tem suas raízes na família de linguagens C e os programadores em C, C++, Java e JavaScript a reconhecerão imediatamente. Este tour fornece uma visão geral dos principais componentes da linguagem no C# 8 e anterior.",
                        Lancamento = new DateTime(2000),
                        Desenvolvedor = "Anders Hejlsberg",
                        Logo = "https://ivaldo.dev/wp-content/uploads/2019/03/27_c-sharp-logo-filled.png"
                    });



                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "Python",
                        Aplicacao = "Python é uma linguagem de programação de alto nível, ou seja, com sintaxe mais simplificada e próxima da linguagem humana, utilizada nas mais diversas aplicações, como desktop, web, servidores e ciência de dados.",
                        Lancamento = new DateTime(1991, 02, 20),
                        Desenvolvedor = "Guido van Rossum",
                        Logo = "https://lh3.googleusercontent.com/proxy/-hIth7N26d3-SvY23aNkHA83ez1AWoFEumc1P1Lr-lPBxaOZMn2H1I_V8hljAExf8yXuKnslZqYVv7jGCWMF1-gKCCKByKOd-F8JWuGoKoO4qa45_ZVK7w-kUtWRyuNs-qCY34j2pB33eyHw"
                    });


                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "JavaScript",
                        Aplicacao = "JavaScript é uma linguagem de programação que permite implementar funcionalidades mais complexas em páginas web. Sempre que uma página web faz mais do que apenas mostrar informações estáticas para você - ela mostra em tempo real conteúdos atualizados, mapas interativos, animações gráficas em 2D/3D, vídeos, etc. -  você pode apostar que o Javascript provavelmente está envolvido.",
                        Lancamento = new DateTime(1995, 12, 04),
                        Desenvolvedor = "Brendan Eich",
                        Logo = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Unofficial_JavaScript_logo_2.svg/1200px-Unofficial_JavaScript_logo_2.svg.png"
                    });


                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "C++",
                        Aplicacao = "O C++ é uma linguagem de programação de nível médio, baseada na linguagem C. O desenvolvimento da linguagem começou na década de 80, por Bjarne Stroustrup. O objetivo do desenvolvimento desta linguagem era melhorar uma versão do núcleo Unix. Para desenvolver a linguagem, foram acrecentados elementos de outras linguagens de vários níveis, na tentativa de criar uma linguagem com elementos novos, sem trazer problemas para a programação. No inicio do desenvolvimento, a linguagem usava um pré-processador, mais Stroustrup criou um compilador próprio, com novas caracteristicas.",
                        Lancamento = new DateTime(1979),
                        Desenvolvedor = "Bjarne Stroustrup",
                        Logo = "https://www.alura.com.br/artigos/assets/formacao-linguagem-c-plus-plus/img-01.png"
                    });


                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "Delphi",
                        Aplicacao = "O Delphi é uma plataforma completa para desenvolvimento de software, seja ele desktop, web ou mobile. Os pilares dessa tecnologia são a IDE, a linguagem e o compilador, todos batizados com o mesmo nome: Delphi. A partir desses três pilares é possível atender às principais necessidades do atual mercado de desenvolvimento de software.",
                        Lancamento = new DateTime(1995),
                        Desenvolvedor = "Anders Hejsberg",
                        Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgrcB-q_MhlPhCjHjn0fZ0pc1D95nqZzhjOPrNZQqYmDesA77HY18S6e1IHkvLa8QIQ90&usqp=CAU"
                    });


                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "Cobol",
                        Aplicacao = "COBOL (sigla de COmmon Business Oriented Language) - Linguagem Comum Orientada para os Negócios é uma linguagem de programação orientada para o processamento de banco de dados comerciais. A linguagem ainda é amplamente utilizada em sistemas legados armazenados em mainframes.",
                        Lancamento = new DateTime(1959),
                        Desenvolvedor = "Grace Hopper, William Selden, Gertrude Tierney, Howard Bromberg, Howard Discount, Vernon Reeves, Jean E. Sammet.",
                        Logo = "https://1.bp.blogspot.com/-ntnQjpJbwPs/XcBIG_zx1jI/AAAAAAAABKc/oZbwtxN66Vwhe4aOfjF9YWeUl9J3dNELgCLcBGAsYHQ/w1200-h630-p-k-no-nu/TjzHDbYEzyBBIHlDyRnP1UHXA.png"
                    });


                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "Java",
                        Aplicacao = "Java é uma linguagem de programação e plataforma computacional lançada pela primeira vez pela Sun Microsystems em 1995. Existem muitas aplicações e sites que não funcionarão, a menos que você tenha o Java instalado, e mais desses são criados todos os dias. O Java é rápido, seguro e confiável.",
                        Lancamento = new DateTime(1995, 05, 23),
                        Desenvolvedor = "James GoslingSun Microsystems",
                        Logo = "https://s2.glbimg.com/2VjTff0ctPGHDSr2IUUAmtiIG0s=/850x446/s2.glbimg.com/vME2Bq4OSpm6f6IE16BhcVLR98U=/695x0/s.glbimg.com/po/tt2/f/original/2014/11/14/java-logo.jpg"
                    });


                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "C",
                        Aplicacao = "C é uma das linguagens de programação mais populares[4][5] e existem poucas arquiteturas para as quais não existem compiladores para C. C tem influenciado muitas outras linguagens de programação (por exemplo, a linguagem Java),[6] mais notavelmente C++, que originalmente começou como uma extensão para C.",
                        Lancamento = new DateTime(1972),
                        Desenvolvedor = "Dennis Ritchie",
                        Logo = "https://i.pinimg.com/originals/13/a8/94/13a89487b6a28c9fd6fee57cf6bc5e2c.png"
                    });


                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "Pascal",
                        Aplicacao = "Pascal é uma linguagem de programação orientada por objetos, que recebeu este nome em homenagem ao matemático e físico Blaise Pascal. Foi criada em 1970 pelo suíço Niklaus Wirth, tendo em mente encorajar o uso de código estruturado.",
                        Lancamento = new DateTime(1970),
                        Desenvolvedor = "Niklaus Wirth",
                        Logo = "https://www.clubemsx.com.br/wp-content/uploads/2020/06/dest-pascal.jpg"
                    });


                    context.Linguagens.Add(new Linguagens
                    {
                        Nome = "ActionScript",
                        Aplicacao = "ActionScript é uma linguagem de script orientada a objetos baseada no ECMAScript, utilizada principalmente para construção de aplicações RIA. É executada em uma máquina virtual, atualmente na versão 3 que está disponível no Adobe Flash Player e também no ambiente Adobe AIR.",
                        Lancamento = new DateTime(1998),
                        Desenvolvedor = "Gary Grossman",
                        Logo = "https://phixies.com.br/publico/tecnologias-galeria/42/!159fbe1688e0b2f801d0215bc4c730bb612ec0c47b32313ce7d82a162d85302e.png"
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}

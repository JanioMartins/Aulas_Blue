using Consultorio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace Consultorio.Data
{
    public static class SeedDatabase
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            
            int qtd_registros = 20;
            string[] nomes = new string[] { "Eurico", "Eduardo", "José", "Italo", "Gabriel", "Alexandre", "Ricardo", "Ycaro", "Caio", "Thales", "Jorge", "Janio", "Josue", "Nivia", "Paula", "Osama", "Ted", "Arnold" };
            string[] sobrenomes = new string[] { "Santos", "Silva", "Freisleben", "Meirelles", "Nogueira", "Teodoro", "Martins", "Ribeiro", "Batalha", "Santana", "Zarantonelo", "Teixeira", "Schwarzenegger", "Kazinscki", "Campos", "Silveira", "Ferrari", "Barros", "Lino", "Russi" };

            using (var context = new ConsultorioContext(serviceProvider.GetRequiredService<DbContextOptions<ConsultorioContext>>()))
            {
                if (context.Paciente.Any())
                {
                    return;
                }

                for (int i =0; i < qtd_registros; i++)
                {
                    Random aleatorio = new Random();

                    // GERANDO NOMES ALEATÓRIOS
                    var nomeCompleto = $"{nomes[aleatorio.Next(0,nomes.Length)]} {sobrenomes[aleatorio.Next(0, sobrenomes.Length)]}";

                    // GERANDO DATAS DE NASCIMENTO ALEATÓRIAS
                    var nascimento = new DateTime(1950, 1, 1);
                    int dias = (DateTime.Today - nascimento).Days;
                    nascimento = nascimento.AddDays(aleatorio.Next(dias));

                    // GERANDO NÚMEROS DE TELEFONE ALEATÓRIOS
                    string telefone = aleatorio.Next(100000000, 999999999).ToString();
                    string ddd = aleatorio.Next(10, 99).ToString();

                    // CRIANDO REGISTRO DE PACIENTE NO BANCO
                    context.Paciente.AddRange(
                        new Paciente
                        {
                            Nome = nomeCompleto,
                            Nascimento = nascimento,
                            Telefone = $"{ddd} {telefone}"
                        }
                    );

                }

                context.SaveChanges();
            }             
            
        }
    }
}

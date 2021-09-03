using Consultorio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Data
{
    public class SeedDatabase
    {

        public static void Initialize(IHost app)
        {

            using (var scope = app.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var context = serviceProvider.GetRequiredService<ConsultorioContext>();
                context.Database.Migrate();

                if (!context.Paciente.Any())
                {
                    context.Paciente.Add(new Paciente { Nome = "Italo", Nascimento = new DateTime(1980, 10, 08), Descricao = "Paciente 1 - Italo" });
                    context.Paciente.Add(new Paciente { Nome = "Eduardo", Nascimento = new DateTime(1995, 01, 25), Descricao = "Paciente 2 - Eduardo" });
                    context.Paciente.Add(new Paciente { Nome = "Janio", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 3 - Janio" });
                    context.Paciente.Add(new Paciente { Nome = "Filipe", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 4 - Filipe" });
                    context.Paciente.Add(new Paciente { Nome = "Gabriel", Nascimento = new DateTime(2000, 7, 5), Descricao = "Paciente 5 - Gabriel" });

                }

                context.SaveChanges();
            }

        }

    }
}

using Consultorio.Models;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Data
{
    //Contexto gerenciam a conexão com o banco de dados
    //Utilizado para criar tabelas, buscar dados, inserir dados, etc
    public class ConsultorioContext : DbContext
    {
        public ConsultorioContext(DbContextOptions<ConsultorioContext> options) : base(options)
        { }


        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
    }
}

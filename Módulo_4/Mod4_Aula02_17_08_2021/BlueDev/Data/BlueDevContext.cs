using BlueDev.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlueDev.Data
{
    //Contexto gerenciam a conexão com o banco de dados
    //Utilizado para criar tabelas, buscar dados, inserir dados, etc
    public class BlueDevContext : IdentityDbContext
    {
        public BlueDevContext(DbContextOptions<BlueDevContext> options) : base(options)
        { }


        public DbSet<Linguagens> Linguagens { get; set; }
        public DbSet<Alunos> Alunos { get; set; }
    }
}


using BlueDev.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDev.Data
{
    public class BlueDevContext : DbContext
    {
        public BlueDevContext(DbContextOptions<BlueDevContext> options) : base(options)
        { }

        public DbSet<Linguagens> Paciente { get; set; }
    }
}

using BlueFashionRetailer.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueFashionRetailer.Data
{
    public class BFRContext : IdentityDbContext
    {

        public BFRContext(DbContextOptions<BFRContext> options)
        : base(options) { }

        public DbSet<Product> Product { get; set; }

    }
}

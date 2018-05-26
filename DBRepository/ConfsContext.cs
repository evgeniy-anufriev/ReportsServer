using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepository
{
    public class ConfsContext : DbContext

    {
        public ConfsContext(DbContextOptions options) : base(options) { }

        public DbSet<Prots> Prots { get; set; }
        public DbSet<Tus> Tus { get; set; } 
    }
}

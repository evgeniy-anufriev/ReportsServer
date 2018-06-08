using Microsoft.EntityFrameworkCore;
using Models.ConfigurationDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBRepository
{
    public class ConfigurationContext : DbContext

    {
        public ConfigurationContext(DbContextOptions options) : base(options) { }

        public DbSet<Protection> Protections { get; set; }
        public DbSet<Tu> Tus { get; set; }
        public DbSet<Report> Reports { get; set; }

  
    }
    
}

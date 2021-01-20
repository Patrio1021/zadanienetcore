using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projekt.Models;

namespace ProjektMS.Models
{
    public class Context : DbContext    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Gry> Grys { get; set; }
        public DbSet<Cena> Cenas { get; set; }
        public DbSet<Kategoria> Kategorias { get; set; }
        public DbSet<projekt.Models.Producent> Producents { get; set; }
    }
}

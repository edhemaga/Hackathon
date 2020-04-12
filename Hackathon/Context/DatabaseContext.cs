using Hackathon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Simptomi> Simptomi { get; set; }
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<KontaktOsoba> KontaktOsobe { get; set; }
    }
}

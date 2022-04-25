using Microsoft.EntityFrameworkCore;
using player_api.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.Entities
{
    public class CodeFirstDemoContext: DbContext
    {
        public CodeFirstDemoContext(DbContextOptions<CodeFirstDemoContext> options)
         :base(options) 
        {
            
        }

        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerInstrument> PlayerInstruments { get; set; }

        public DbSet<InstrumentType> InstrumentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                    .HasMany(p => p.Instruments)
                    .WithOne();

            modelBuilder.Seed();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using player_api.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.Entities
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InstrumentType>().HasData(
                new InstrumentType { InstrumentTypeId = 1, Name = "Acoustic Guitar" },
                new InstrumentType { InstrumentTypeId = 2, Name = "Electric Guitar" },
                new InstrumentType { InstrumentTypeId = 3, Name = "Drums" },
                new InstrumentType { InstrumentTypeId = 4, Name = "Bass" },
                new InstrumentType { InstrumentTypeId = 5, Name = "Keyboard" }
            );
        }
    }
}

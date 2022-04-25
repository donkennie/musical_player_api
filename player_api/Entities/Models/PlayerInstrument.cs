using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.Entities.Models
{
    public class PlayerInstrument
    {

        public int PlayerInstrumentId { get; set; }

        public int PlayerId { get; set; }

        public int InstrumentTypeId { get; set; }

        public string ModelName { get; set; }

        public string Level { get; set; }

    }
}

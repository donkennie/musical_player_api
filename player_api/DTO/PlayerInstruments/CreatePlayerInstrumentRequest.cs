using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.DTO.PlayerInstruments
{
    public class CreatePlayerInstrumentRequest
    {
        public int InstrumentTypeId { get; set; }
        public string ModelName { get; set; }
        public string Level { get; set; }
    }
}

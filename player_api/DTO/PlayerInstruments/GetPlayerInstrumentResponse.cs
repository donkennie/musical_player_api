using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.DTO.PlayerInstruments
{
    public class GetPlayerInstrumentResponse
    {
        public string InstrumentTypeName { get; set; }
        public string ModelName { get; set; }
        public string Level { get; set; }
    }
}

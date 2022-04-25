using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.DTO.Players
{
    public class GetPlayerResponse
    {
        public int PlayerId { get; set; }
        public string NickName { get; set; }
        public DateTime JoinedDate { get; set; }
        public int InstrumentSubmittedCount { get; set; }

    }
}

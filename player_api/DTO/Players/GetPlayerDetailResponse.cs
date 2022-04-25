using player_api.DTO.PlayerInstruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.DTO.Players
{
    public class GetPlayerDetailResponse
    {

        public string NickName { get; set; }

        public DateTime JoinedDate { get; set; }

        public List<GetPlayerInstrumentResponse> PlayerInstruments{ get; set; }
    }
}

using player_api.DTO.PlayerInstruments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.DTO.Players
{
    public class CreatePlayerRequest
    {
        [Required]
        public string NickName { get; set; }

        [Required]
        public List<CreatePlayerInstrumentRequest> PlayerInstruments{ get; set; }
    
    }
}

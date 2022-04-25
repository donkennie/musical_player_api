using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.Entities.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string NickName { get; set; }

        public List<PlayerInstrument> Instruments { get; set; }

        public DateTime JoinedDate { get; set; }
    }
}

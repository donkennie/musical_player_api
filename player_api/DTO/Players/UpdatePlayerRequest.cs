using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.DTO.Players
{
    public class UpdatePlayerRequest
    {
        [Required]
        public string NickName { get; set; }
    }
}

using player_api.DTO;
using player_api.DTO.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace player_api.Interfaces
{
    public interface IPlayerService
    {
        Task CreatePlayerAsync(CreatePlayerRequest playerRequest);
        Task<PagedResponse<GetPlayerResponse>> GetPlayersAsync(UrlQueryParameters urlQueryParameters);
        Task<GetPlayerDetailResponse> GetPlayerDetailAsync(int id);
        Task<bool> UpdatePlayerAsync(int id, UpdatePlayerRequest playerRequest);
        Task<bool> DeletePlayerAsync(int id);
    }
}

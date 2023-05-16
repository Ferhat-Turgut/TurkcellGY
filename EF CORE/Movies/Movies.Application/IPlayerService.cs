using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;

namespace Movies.Application
{
    public interface IPlayerService
    {
        Task<int> CreateNewPlayer(CreateNewPlayerRequset requset);
        Task<SinglePlayerResponse> GetPlayerAsync(int id);
        Task<IEnumerable<PlayerListResponse>> GetPlayerLists();
        Task UpdatePlayerAsync(UpdatePlayerRequest request);
    }
}
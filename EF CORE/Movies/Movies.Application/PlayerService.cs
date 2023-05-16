using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using Movies.Data.Repositories;
using Movies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository repository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            this.repository = playerRepository;
        }

        public async Task<IEnumerable<PlayerListResponse>> GetPlayerLists()
        {
            var players = await repository.GetAllAsync();
            return players.Select(p => new PlayerListResponse
            {
                Id = p.Id,
                Name = p.Name,
                LastName = p.LastName,
                Info = p.Info
            });
        }

        public async Task<int> CreateNewPlayer(CreateNewPlayerRequset requset)
        {
            Player player = new()
            {
                Name = requset.Name,
                LastName = requset.LastName,
                Info = requset.Info
            };
            await repository.CreateAsync(player);
            return player.Id;
        }
        public async Task<SinglePlayerResponse> GetPlayerAsync(int id)
        {
            var player = await repository.GetByIdAsync(id);
            return new SinglePlayerResponse
            {
                Name = player.Name,
                LastName = player.LastName,
                Info = player.Info
            };
        }

        public async Task UpdatePlayerAsync(UpdatePlayerRequest request)
        {
            var player = new Player()
            {
                Id = request.Id,
                Name = request.Name,
                LastName = request.LastName,
                Info = request.Info
            };
            await repository.UpdateAsync(player);
        }

    }
}

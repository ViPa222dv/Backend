using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPractice.Models.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly PlayerContext _pContext;
        public PlayerRepository(PlayerContext _pContext)
        {
            _pContext = _pContext;
        }
        public async Task<Player> Create(Player player)
        {
            _pContext.Player.Add(player);
            await _pContext.SaveChangesAsync();
            return player;
        }

        public async Task Delete(int id)
        {
            var playerToDelete = await _pContext.Player.FindAsync(id);
            _pContext.Player.Remove(playerToDelete);
            await _pContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Player>> Get()
        {
            return await _pContext.Player.ToListAsync();
        }

        public async Task<Player> Get(int id)
        {
            return await _pContext.Player.FindAsync(id);
        }

        public async Task Update(Player player)
        {
            _pContext.Entry(player).State = EntityState.Modified;
            await _pContext.SaveChangesAsync();
        }
    }
}

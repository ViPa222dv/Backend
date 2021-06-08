using Microsoft.EntityFrameworkCore;
using PracticingDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticingDB.Models.Repositories
{
    public class FootballPlayerRepository : IPlayerRepository
    {
        private readonly PlayerContext _pContext;
        public FootballPlayerRepository(PlayerContext pContext)
        {
            _pContext = _pContext;
        }
        public async Task<FootballPlayer> Create(FootballPlayer footballPlayer)
        {
            _pContext.FootballPlayers.Add(footballPlayer);
            await _pContext.SaveChangesAsync();
            return footballPlayer;
        }

        public async Task Delete(int id)
        {
            var playerToDelete = await _pContext.FootballPlayers.FindAsync(id);
            _pContext.FootballPlayers.Remove(playerToDelete);
            await _pContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<FootballPlayer>> Get()
        {
            return await _pContext.FootballPlayers.ToListAsync();
        }

        public async Task<FootballPlayer> Get(int id)
        {
            return await _pContext.FootballPlayers.FindAsync(id);
        }

        public async Task Update(FootballPlayer footballPlayer)
        {
            _pContext.Entry(footballPlayer).State = EntityState.Modified;
            await _pContext.SaveChangesAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticingDB.Models.Repositories
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<FootballPlayer>> Get();
        Task<FootballPlayer> Get(int id);
        Task<FootballPlayer> Create(FootballPlayer footballPlayer);
        Task Update(FootballPlayer footballPlayer);
        Task Delete(int id);

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticingDB.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<FootballPlayer> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<FootballPlayer> FootballPlayers { get; set; }
    }
}

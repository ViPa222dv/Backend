using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPractice.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Player> Player { get; set; }
    }
}

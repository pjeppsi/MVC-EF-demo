using Microsoft.EntityFrameworkCore;

namespace MVW_EF_Razor_demo.Models
{
    public class RatingSystemContext : DbContext
    {
        public RatingSystemContext(DbContextOptions<RatingSystemContext> options): base(options) { }

        public DbSet<MatchGame> MatchGames { get; set;}
        public DbSet<Player> Player { get; set;}
        public DbSet<Team> Team { get; set;}
        public DbSet<Rating> Rating { get; set;}
    }
}

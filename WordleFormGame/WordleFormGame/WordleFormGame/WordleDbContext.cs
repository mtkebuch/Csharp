using System.Data.Entity;

namespace WordleFormGame
{
    public class WordleDbContext : DbContext
    {
        public WordleDbContext() : base("name=WordleDbConnection")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Guess> Guesses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Round>()
                .HasRequired(r => r.Player)
                .WithMany()
                .HasForeignKey(r => r.PlayerId);

            modelBuilder.Entity<Guess>()
                .HasRequired(g => g.Round)
                .WithMany()
                .HasForeignKey(g => g.RoundId);
        }
    }
}

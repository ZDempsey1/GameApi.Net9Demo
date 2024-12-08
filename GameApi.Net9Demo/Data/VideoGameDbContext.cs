using GameApi.Net9Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace GameApi.Net9Demo.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options) 
    {
        public DbSet<VideoGame> VideoGames => Set<VideoGame>();
        public DbSet<VideoGameDetails> VideoGameDetails => Set<VideoGameDetails>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(

                new VideoGame
                {
                    Id = 1,
                    Title = "Spider-Man 2",
                    Platform = "PS5"
                },
                new VideoGame
                {
                    Id = 2,
                    Title = "The legend of Zelda: Breath of the Wild",
                    Platform = "Nintendo Switch"
                },
                new VideoGame
                {
                    Id = 3,
                    Title = "Cyberpunk 2077",
                    Platform = "PC"
                },
                new VideoGame
                {
                    Id = 4,
                    Title = "Dune",
                    Platform = "XBOX360"
                }
            );
        }
    }
}

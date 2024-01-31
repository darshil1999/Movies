using Microsoft.EntityFrameworkCore;

namespace Movies.Entities
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> option) : base(option) 
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { MovieId = 1, Name = "Movie 1", Year = 1999, Rating = 5 },
                new Movie() { MovieId = 2, Name = "Movie 2", Year = 1999, Rating = 5 },
                new Movie() { MovieId = 3, Name = "Movie 3", Year = 2023, Rating = 2 },
                new Movie() { MovieId = 4, Name = "Movie 4", Year = 1888, Rating = 4 }
                );
        }
    }
}

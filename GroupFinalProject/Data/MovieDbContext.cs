
using GroupFinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GroupFinalProject.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Studio> Studios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>()
                .HasOne(movie => movie.Genre)
                .WithMany(genre => genre.Movies)
                .HasForeignKey(movie => movie.GenreID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Movie>()
                .HasOne(movie => movie.Director)
                .WithMany(director => director.Movies)
                .HasForeignKey(movie => movie.DirectorID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Movie>()
                .HasOne(movie => movie.Studio)
                .WithMany(studio => studio.Movies)
                .HasForeignKey(movie => movie.StudioID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

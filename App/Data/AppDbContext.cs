using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-GETPKV5T;Initial Catalog=CinematKO;Integrated Security=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(ActorMovie => new
            {
                ActorMovie.ActorId,
                ActorMovie.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(Actor => Actor.Actor).WithMany(ActorMovie => ActorMovie.Actors_Movies).HasForeignKey(Actor => Actor.ActorId);
            modelBuilder.Entity<Actor_Movie>().HasOne(Movie => Movie.Movie).WithMany(ActorMovie => ActorMovie.Actors_Movies).HasForeignKey(Movie => Movie.MovieId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}

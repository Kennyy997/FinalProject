using System.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieFinalProject.DataContext.Entities;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace MovieFinalProject.DataContext
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Quality> Qualitys { get; set; }
        public DbSet<Rating> Ratings { get; set; }


    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieFinalProject.DataAccessLayer.Entities;
using MovieFinalProject.DataContext.Entities;
namespace MovieFinalProject.DataAccessLayer
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Quality> Qualitys { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ExpectedMovies> ExpectedMovies { get; set; }



    }
}
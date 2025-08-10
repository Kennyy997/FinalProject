using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieFinalProject.DataBase.Entities;
using MovieFinalProject.DataContext.Entities;

namespace MovieFinalProject.DataContext
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }
        public DbSet<WatchHistory> WatchHistories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }
        public DbSet<GenreMovie> GenreMovies { get; set; }
        public DbSet<ActorGenre> ActorGenres { get; set; }
        public DbSet<ActorRating> ActorRatings { get; set; }
    }
}
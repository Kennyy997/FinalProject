using MovieFinalProject.Controllers;
using MovieFinalProject.DataAccessLayer.Entities;
using MovieFinalProject.DataContext.Entities;
using Restaurant.Controllers;

namespace MovieFinalProject.ViewModel
{
    public class HomeViewModel
    {
    
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<Actor> Actors { get; set; } = new List<Actor>();
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Slider> Sliders { get; set; } = new List<Slider>();
        public List<ExpectedMovies> ExpectedMovies { get; set; } = new List<ExpectedMovies>();
        public List<Quality> Qualities { get; set; } = new List<Quality>();
        public List<AppUser> appUsers { get; set; } = new List<AppUser>();
    }
}

using MovieFinalProject.Controllers;
using MovieFinalProject.DataContext.Entities;

namespace MovieFinalProject.ViewModel
{
    public class HomeViewModel
    {
    
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<Movie> ExpectedMovies { get; set; } = new List<Movie>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<Actor> Actors { get; set; } = new List<Actor>();
        public List<Quality> Qualities { get; set; } = new List<Quality>();
        public int TotalMoviesCount { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 18;

     }
}

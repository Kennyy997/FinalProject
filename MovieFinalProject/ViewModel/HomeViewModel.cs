using MovieFinalProject.DataContext.Entities;

namespace MovieFinalProject.ViewModel
{
    public class HomeViewModel
    {
    {
        public List<Movie> HeroMovies { get; set; } = new List<Movie>();
        public List<Movie> CatalogMovies { get; set; } = new List<Movie>();
        public List<Movie> ExpectedMovies { get; set; } = new List<Movie>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Quality> Qualities { get; set; } = new List<Quality>();
        public int TotalMoviesCount { get; set; }
        public int CurrentPage { get; set; } = 1;
        public int PageSize { get; set; } = 18;

        // Helper metodları
        public double GetMovieRating(Movie movie)
        {
            return movie.Reviews?.Any() == true ? movie.Reviews.Average(r => r.Point) : 0;
        }

        public string GetRatingClass(double rating)
        {
            return rating >= 7 ? "green" : rating >= 5 ? "yellow" : "red";
        }

        public List<Actor> GetMainActors(Movie movie, int count = 2)
        {
            return movie.MovieActors?.Take(count).Select(ma => ma.Actor).ToList() ?? new List<Actor>();
        }
    }
}
}

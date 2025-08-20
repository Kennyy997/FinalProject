using MovieFinalProject.DataAccessLayer.Entities;
using MovieFinalProject.DataContext.Entities;

public class Movie : BaseEntity
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string Director { get; set; }
    public required string Cast { get; set; }
    public required DateTime ReleaseDate { get; set; }
    public required int MovieTime { get; set; } 
    public required decimal Rating { get; set; }
    public required string PosterUrl { get; set; }
    public  string TrailerUrl { get; set; } = null!;
    public required int GenreId { get; set; }
    public int CountryId { get; set; }
    public List<Country> Country { get; set; } = new List<Country>();
    public List<Slider> sliders { get; set; }= new List<Slider>();
    public List<Genre> Genres { get; set; } = new List<Genre>();
    public List<Actor> Actors { get; set; } = new List<Actor>();
    public List<Review> ?Reviews { get; set; }
}

using MovieFinalProject.DataContext.Entities;

public class Movie : BaseEntity
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required DateTime ReleaseDate { get; set; }
    public required int MovieTime { get; set; } 
    public required decimal Rating { get; set; }
    public required IFormFile PosterUrl { get; set; }
    public  IFormFile TrailerUrl { get; set; } = null!;
    public required int GenreId { get; set; }
    public Genre ?Genre { get; set; }
    public int CountryId { get; set; }
    public Country? Country { get; set; }
    public List<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
    public List<Review> ?Reviews { get; set; }
}

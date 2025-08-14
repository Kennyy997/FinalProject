namespace MovieFinalProject.DataContext.Entities;

public class Genre : BaseEntity
{
    public required string Name { get; set; }
    public List<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();


}
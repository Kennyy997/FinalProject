namespace MovieFinalProject.DataContext.Entities;

public class Genre : BaseEntity
{
    public required string Name { get; set; }

    public List<MovieGenre> Movies { get; set; } = new List<MovieGenre>();
}
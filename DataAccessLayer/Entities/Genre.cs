namespace MovieFinalProject.DataContext.Entities;

public class Genre : BaseEntity
{
    public required string Name { get; set; }
    public List<Movie> Movie { get; set; } = new List<Movie>();


}
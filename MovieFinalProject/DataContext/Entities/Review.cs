namespace MovieFinalProject.DataContext.Entities;

public class Review : BaseEntity
{
    public required string Name { get; set; }
    public required string Comment { get; set; }
    public int Rating { get; set; } 
    public DateTime CreatedAt { get; set; }
    public int MovieId { get; set; }
    public Movie? Movie { get; set; }
}


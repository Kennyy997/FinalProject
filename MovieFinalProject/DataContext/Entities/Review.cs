namespace MovieFinalProject.DataContext.Entities;

public class Review : BaseEntity
{
    public int UserId { get; set; }
    public AppUser? AppUser { get; set; }

    public int MovieId { get; set; }
    public Movie ?Movie { get; set; }

    public int Rating { get; set; } 
    public required string Comment { get; set; }
    public DateTime CreatedAt { get; set; }

}


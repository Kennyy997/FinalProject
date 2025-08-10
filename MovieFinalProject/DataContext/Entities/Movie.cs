namespace MovieFinalProject.DataContext.Entities
{
    public class Movie : BaseEntity
    {
        public required string Title { get; set; } 
        public required string Description { get; set; } 
        public required string Director { get; set; } 
        public required DateTime ReleaseDate { get; set; }
        public required Genre Genre { get; set; }
        public required Rating Rating { get; set; }
        public required string Coverimg { get; set; } 
        public required double RunningTimes { get; set; }
        public required string TrailerUrl { get; set; }
        public required string Country { get; set; }
    }
}

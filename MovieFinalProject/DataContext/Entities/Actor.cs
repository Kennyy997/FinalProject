namespace MovieFinalProject.DataContext.Entities
{
    public class Actor : BaseEntity
    {
        public required string Name { get; set; }
        public required string Biography { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string BornPlace { get; set; }
        public required string ProfilePicture { get; set; }
         public required int Age { get; set; }
        public required string Zodiac { get; set; } 
        public required List<Genre>Genres { get; set; } 
        public required int TotalMovies { get; set; }
        public required string FirstMovie { get; set; }
        public required string LastMovie { get; set; }
        public required string BestMovie { get; set; }
        public List<MovieActor> MovieActors { get; set; } = new List<MovieActor>();

    }
}

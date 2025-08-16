namespace MovieFinalProject.DataContext.Entities
{
    public class Rating : BaseEntity
    {
        public int Score { get; set; }  
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        public int UserId { get; set; }
        public AppUser? User { get; set; }  
    }
}

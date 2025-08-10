namespace MovieFinalProject.DataContext.Entities
{
    public class Country : BaseEntity
    {
        public required string Name { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();

    }
}

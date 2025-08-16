using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.DataContext.Entities;

namespace MovieFinalProjectBusinessLogicLayer.Dto_s
{
   public class MovieDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required DateTime ReleaseDate { get; set; }
        public required int MovieTime { get; set; }
        public required decimal Rating { get; set; }
        public required string PosterUrl { get; set; }
        public string TrailerUrl { get; set; } = null!;
        public required int GenreId { get; set; }
        public Genre? Genre { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Actor> Actors  { get; set; } = new List<Actor>();
        public List<Review>? Reviews { get; set; }
    }
    public class MovieCreateDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required DateTime ReleaseDate { get; set; }
        public required int MovieTime { get; set; }
        public required decimal Rating { get; set; }
        public required string PosterUrl { get; set; }
        public string TrailerUrl { get; set; } = null!;
        public required int GenreId { get; set; }
        public int CountryId { get; set; }
    }
    public class MovieUpdateDto
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required DateTime ReleaseDate { get; set; }
        public required int MovieTime { get; set; }
        public required decimal Rating { get; set; }
        public required string PosterUrl { get; set; }
        public string TrailerUrl { get; set; } = null!;
        public required int GenreId { get; set; }
        public int CountryId { get; set; }
    }
}

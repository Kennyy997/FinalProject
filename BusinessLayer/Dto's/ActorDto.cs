using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.DataContext.Entities;

namespace MovieFinalProjectBusinessLogicLayer.Dto_s
{
   public class ActorDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Biography { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string BornPlace { get; set; }
        public required string ProfilePicture { get; set; }
        public required int Age { get; set; }
        public required string Zodiac { get; set; }
        public required List<Genre> Genres { get; set; }
        public required int TotalMovies { get; set; }
        public required string FirstMovie { get; set; }
        public required string LastMovie { get; set; }
        public required string BestMovie { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
    public class ActorCreateDto
    {
        public required string Name { get; set; }
        public required string Biography { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string BornPlace { get; set; }
        public required string ProfilePicture { get; set; }
        public required int Age { get; set; }
        public required string Zodiac { get; set; }
        public required List<Genre> Genres { get; set; } = new List<Genre>();
        public required int TotalMovies { get; set; }
        public required string FirstMovie { get; set; }
        public required string LastMovie { get; set; }
        public required string BestMovie { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();

    }
    public class ActorUpdateDto
    {
        public required string Name { get; set; }
        public required string Biography { get; set; }
        public required DateTime DateOfBirth { get; set; }
        public required string BornPlace { get; set; }
        public required string ProfilePicture { get; set; }
        public required int Age { get; set; }
        public required string Zodiac { get; set; }
        public required List<Genre> Genres { get; set; } = new List<Genre>();
        public required int TotalMovies { get; set; }
        public required string FirstMovie { get; set; }
        public required string LastMovie { get; set; }
        public required string BestMovie { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.DataContext.Entities;

namespace MovieFinalProjectBusinessLogicLayer.Dto_s
{
   public class GenreDto
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
    public class GenreCreateDto
    {
        public required string Name { get; set; }
    }
    public class GenreUpdateDto
    {
        public required string Name { get; set; }
    }
}

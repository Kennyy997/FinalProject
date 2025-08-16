using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinalProjectBusinessLogicLayer.Dto_s
{
   public  class ReviewDto
    {
        public required string Name { get; set; }
        public required string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
    public class ReviewCreateDto
    {
        public required string Name { get; set; }
        public required string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public int MovieId { get; set; }
    }
    public class ReviewUpdateDto
    {
        public required string Name { get; set; }
        public required string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public int MovieId { get; set; }
    }
}

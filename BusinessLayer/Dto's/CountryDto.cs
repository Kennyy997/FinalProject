using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinalProjectBusinessLogicLayer.Dto_s
{
   public class CountryDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
    public class CountryCreateDto
    {
        public required string Name { get; set; }
    }
    public class CountryUpdateDto
    {
        public required string Name { get; set; }
    }
}

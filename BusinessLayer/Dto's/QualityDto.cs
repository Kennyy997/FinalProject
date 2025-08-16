using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinalProjectBusinessLogicLayer.Dto_s
{
   public class QualityDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }

    }
    public class QualityCreateDto
    {
        public required string Name { get; set; }
    }
    public class QualityUpdateDto
    {
        public required string Name { get; set; }
    }
}

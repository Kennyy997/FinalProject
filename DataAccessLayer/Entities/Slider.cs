using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieFinalProject.DataContext.Entities;

namespace MovieFinalProject.DataAccessLayer.Entities
{
   public class Slider : BaseEntity
    {
        public string imageUrl { get; set; } = null!;
    }
}

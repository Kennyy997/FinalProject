using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieFinalProject.BusinessLogicLayer.Dtos
{
    // Rating-i göstərmək üçün DTO
    public class RatingDto
    {
        public int Id { get; set; }
        public int Score { get; set; }  // məsələn 1–5 və ya 1–10 arası

        public int MovieId { get; set; }
        public string? MovieTitle { get; set; } // sadəcə lazım olan info

        public int UserId { get; set; }
        public string? UserName { get; set; } // optional
    }

    // Yeni rating əlavə etmək üçün DTO
    public class RatingCreateDto
    {
        public int MovieId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
    }

    // Mövcud rating-i update etmək üçün DTO
    public class RatingUpdateDto
    {
        public int Id { get; set; }
        public int Score { get; set; }
    }
}


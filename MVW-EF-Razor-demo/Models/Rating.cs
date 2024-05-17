using System.ComponentModel.DataAnnotations;

namespace MVW_EF_Razor_demo.Models
{
    public class Rating
    {
        public int Id { get; set; }
        [Required]
        public int RatingValue { get; set; }
        [Required]
        public Player RatedPlayer { get; set; }
        [Required]
        public List<MatchGame> MatchGames { get; set; }
    }
}

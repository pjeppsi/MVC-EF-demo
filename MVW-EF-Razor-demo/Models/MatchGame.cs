using System.ComponentModel.DataAnnotations;

namespace MVW_EF_Razor_demo.Models
{
    public class MatchGame
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateOfPlay { get; set; }
        [Required]
        public List<Team> Teams { get; set; }
        [Required]
        public List<Rating> Ratings { get; set; }
    }
}

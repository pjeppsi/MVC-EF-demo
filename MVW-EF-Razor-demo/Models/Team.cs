using System.ComponentModel.DataAnnotations;

namespace MVW_EF_Razor_demo.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public List<Player> Players { get; set; }
    }
}

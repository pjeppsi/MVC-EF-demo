using System.ComponentModel.DataAnnotations;

namespace MVW_EF_Razor_demo.Models
{
    public class Player
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Surname { get; set; }

    }
}

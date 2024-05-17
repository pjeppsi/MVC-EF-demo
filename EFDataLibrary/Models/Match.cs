using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataLibrary.Models
{
    public class Match
    {
        public int Id { get; set; }
        public List<TeamMatchup> Teams { get; set; } = new List<TeamMatchup>();
        
    }
}

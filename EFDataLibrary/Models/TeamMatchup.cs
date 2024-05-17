using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataLibrary.Models
{
    public class TeamMatchup
    {
        public int Id { get; set; }
        public List<Person> Players { get; set; } = new List<Person>();
    }
}

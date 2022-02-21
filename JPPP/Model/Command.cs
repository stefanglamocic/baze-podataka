using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPPP.Model
{
    public class Command
    {
        public int CommandID { get; set; }
        public User Meteorologist { get; set; }
        public User Operator { get; set; }
        public DateTime Date { get; set; }
        public int Azimuth { get; set; }
        public int Elevation { get; set; }
        public List<Rockets> Rockets { get; set; }
    }
}

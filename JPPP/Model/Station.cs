using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPPP.Model
{
    class Station
    {
        public int StationID { get; set; }
        public string Municipality { get; set; }
        public string Place { get; set; }
        public int RegisteredOperatorID { get; set; }
        public User Operator { get; set; }
    }
}

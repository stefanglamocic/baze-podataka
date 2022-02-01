using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPPP.Model
{
    class Message
    {
        public String Content { get; set; }
        public DateTime Date { get; set; }
        public int OperatorID { get; set; }
        public int MeteorologistID { get; set; }
        public int MessageID { get; set; }
        public User Operator { get; set; }
        public User Meteorologist { get; set; }
    }
}

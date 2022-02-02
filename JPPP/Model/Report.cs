using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPPP.Model
{
    class Report
    {
        public int ReportID { get; set; }
        public DateTime Date { get; set; }
        public String Message { get; set; }
        public Station Station { get; set; }
        public User Meteorologist { get; set; }
        public User AdminWorker { get; set; }
    }
}

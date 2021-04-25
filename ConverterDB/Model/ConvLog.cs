using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDb
{
    public class ConvLog
    {
        public int Id { get; set; }
        public string NameOfConverter { get; set; }
        public string UnitTo { get; set; }
        public string UnitFrom { get; set; }
        public double Value{ get; set; }
        public DateTime Date{ get; set; }
    }
}

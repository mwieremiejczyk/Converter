using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDb
{
    public class AddNewLog
    {
        public void InsertLog(string NoC, string UT, string UF, double V)
        {
            using (LogDataContex contex = new LogDataContex())
            {
                ConvLog templog = new ConvLog();
                templog.NameOfConverter = NoC;
                templog.UnitTo = UT;
                templog.UnitFrom = UF;
                templog.Value = V;
                templog.Date = DateTime.Now;

                contex.ConverterLogs.Add(templog);
                contex.SaveChanges();
              
            }

        }
    }
}

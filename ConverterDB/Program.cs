using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDb
{
    class Program
    {
        static void Main(string[] arg)
        {
            DisplayLogs();
            //InsertLog();
        }

        private static void DisplayLogs()
        {
            using(LogDataContex contex = new LogDataContex())
            {
                List<ConvLog> Mylist = contex.ConverterLogs.ToList();

                foreach(var item in Mylist)
                {
                    Console.WriteLine(item.NameOfConverter);

                }
            }
        }

        public void InsertLog()
        {
            using (LogDataContex contex = new LogDataContex())
            {
                Console.WriteLine("tel");


            }

        }



    }
}

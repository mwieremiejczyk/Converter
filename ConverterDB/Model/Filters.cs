using LoadDb;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterDB
{
    public class Filters
    {
        public ObservableCollection<ConvLog> LogList { get; set; } = new ObservableCollection<ConvLog>();

        public string TypeOfConverter { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public bool isChecked { get; set; }

        public Filters(DateTime Df, DateTime Dt, string ToC, bool ch)
        {
            DateFrom = Df;
            DateTo = Dt;
            TypeOfConverter = ToC;
            isChecked = ch;



            using (LogDataContex contex = new LogDataContex())
            {
                List<ConvLog> Mylist = contex.ConverterLogs.Where(x => x.Date <= DateTo && x.Date >= DateFrom).ToList();
                              Mylist = contex.ConverterLogs.Where(x => x.NameOfConverter==TypeOfConverter).ToList();

                //var ttt = Mylist.GroupBy(q => q.NameOfConverter)
                //                    .OrderByDescending(gp => gp.Count())
                //                    .Take(3)
                //                    .Select(g => g.Key).ToList();

                foreach (var item in Mylist)
                {
                    LogList.Add(item);
                }
            }
        }

    }
}
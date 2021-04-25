using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoadDb
{
    public class LoadDB
    {
        public ObservableCollection<ConvLog> LogList { get; set; } = new ObservableCollection<ConvLog>();

        public LoadDB()
        {
            using (LogDataContex contex = new LogDataContex())
            {
                List<ConvLog> Mylist = contex.ConverterLogs.ToList();

                foreach (var item in Mylist)
                {
                    LogList.Add(item);               
                }
            }
        }

    }
}

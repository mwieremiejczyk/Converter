using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwerter_2._0v
{
    public class TimeConverter: IConverter
    {
        public string Name => "Czas \t\t[s], [m], [h]";
        public List<string> Units => new List<string>()
        {
            "s",
            "m",
            "h"
        };
        public decimal Convert(decimal ValueToConvert, string unitFrom, string unitTo)
        {
            if (unitFrom == "s")
            {
                if (unitTo == "m")
                {
                    return ValueToConvert/60;
                }
                else if (unitTo == "h")
                {
                    return ValueToConvert/3600;
                }
            }


            else if (unitFrom == "m")
            {
                if (unitTo == "s")
                {
                    return ValueToConvert*60;
                }
                else if (unitTo == "h")
                {
                    return ValueToConvert/60;
                }
            }


            else if (unitFrom == "h")
            {
                if (unitTo == "s")
                {
                    return ValueToConvert * 3060;
                }
                else if (unitTo == "m")
                {
                    return ValueToConvert * 60;
                }
            }

            return 0;
        }



    }
}

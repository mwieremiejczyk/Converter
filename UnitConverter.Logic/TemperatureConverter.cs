using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwerter_2._0v
{
    public class TemperatureConverter: IConverter
    {
        public string Name => "Temperatura \t[C], [K], [F]";
        public List<string> Units => new List<string>()
        {
            "C",
            "K",
            "F"
        };
        public decimal Convert(decimal ValueToConvert, string unitFrom, string unitTo)
        {
            if(unitFrom=="C")
            {
                if(unitTo=="K")
                {
                    return ValueToConvert+273;
                }
                else if(unitTo=="F")
                {
                    return ValueToConvert*1.8m+32;
                }
            }


            else if (unitFrom == "K")
            {
                if (unitTo == "C")
                {
                    return ValueToConvert-273;
                }
                else if (unitTo == "F")
                {
                    return ((ValueToConvert-273)*1.8m)+32;
                }
            }


            else if(unitFrom == "F")
            {
                if (unitTo == "C")
                {
                    return (ValueToConvert-32)/1.8m;
                }
                else if (unitTo == "K")
                {
                    return ((ValueToConvert - 32)/ 1.8m)+273;
                }
            }

            return 0;
        }



    }
}

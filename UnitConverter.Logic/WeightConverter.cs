using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwerter_2._0v
{
    public class WeightConverter : IConverter
    {
        public string Name => "Waga \t\t[Kg], [G], [T]";

        public List<string> Units => new List<string>()
        {
            "Kg",
            "G",
            "T"
        };

        public decimal Convert(decimal ValueToConvert, string unitFrom, string unitTo)
        {
            if (unitFrom == "Kg")
            {
                if (unitTo == "G")
                {
                    return ValueToConvert*1000;
                }
                else if (unitTo == "T")
                {
                    return ValueToConvert/1000;
                }
            }


            else if (unitFrom == "G")
            {
                if (unitTo == "Kg")
                {
                    return ValueToConvert/1000;
                }
                else if (unitTo == "T")
                {
                    return ValueToConvert/1000000;
                }
            }


            else if (unitFrom == "T")
            {
                if (unitTo == "Kg")
                {
                    return ValueToConvert*1000;
                }
                else if (unitTo == "G")
                {
                    return ValueToConvert*1000000;
                }
            }

            return 0;
        }

    }
}

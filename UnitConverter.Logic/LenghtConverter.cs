using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwerter_2._0v


{
    public class LenghtConverter : IConverter
    {
        public string Name => "Długość \t\t[Km], [M], [Mile]";

        public List<string> Units => new List<string>()
        {
            "Km",
            "M",
            "Mile"
        };

        public decimal Convert(decimal ValueToConvert, string unitFrom, string unitTo)
        {
            if (unitFrom == "Km")
            {
                if (unitTo == "M")
                {
                    return ValueToConvert*1000;
                }
                else if (unitTo == "Mile")
                {
                    return ValueToConvert*0.62m;
                }
            }


            else if (unitFrom == "M")
            {
                if (unitTo == "Km")
                {
                    return ValueToConvert/1000;
                }
                else if (unitTo == "Mile")
                {
                    return ValueToConvert/1851;
                }
            }


            else if (unitFrom == "Mile")
            {
                if (unitTo == "M")
                {
                    return ValueToConvert*1851;
                }
                else if (unitTo == "Km")
                {
                    return ValueToConvert/0.62m;
                }
            }

            return 0;
        }

    }
}

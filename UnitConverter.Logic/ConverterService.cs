using Konwerter_2._0v;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter.Logic
{
    public class ConverterService
    {
        public List <IConverter> GetConverters()
        {
            return new List<IConverter>()
            {
                new LenghtConverter(),
                new TimeConverter(),
                new WeightConverter(),
                new TemperatureConverter()

            };

        }
    }
}

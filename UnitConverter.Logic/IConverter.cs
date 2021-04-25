using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwerter_2._0v
{
    public interface IConverter
    {
        string Name { get; }
        List<string> Units { get; }

        decimal Convert(decimal ValueToConvert, string unitFrom, string unitTo);
      
    }
}

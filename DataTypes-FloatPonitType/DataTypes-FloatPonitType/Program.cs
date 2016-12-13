using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_FloatPonitType
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("Min Value {0}, Max Value {1} ", flMin, flMax);
            float flVar = 1F / 3;
            Double dlVar = 1d / 3;
            decimal dcVar = 1M / 3;
            Console.WriteLine("Float Varible {0}\nDouble Varible {1}\nDecimal Varible {2}", flVar, dlVar, dcVar);
            Console.ReadKey();
        }
    }
}

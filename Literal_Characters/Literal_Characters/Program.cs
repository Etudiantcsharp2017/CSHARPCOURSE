using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = -100;
            uint myUvar = 1000U;
            ulong myLvar = 1000uL;
            float myFlvar = 1.5F;
            double myDvar = 100.5D;
            decimal myDecvar = 100.5M;
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", myVar,myUvar,myLvar,myFlvar,myDvar,myDecvar);
            Console.WriteLine($"{myDecvar},{myDvar}");
            Console.ReadKey();
        }
    }
}

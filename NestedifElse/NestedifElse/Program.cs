using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 4, myVar2 = 6;
            if(myVar<=3 && myVar>=5)
            {
                Console.WriteLine("Condition one rignt ");
            }
            else if (myVar<=4 && myVar2>=6)
            {
                Console.WriteLine("Condition two rignt");
            }
            else if (myVar2>5)
            {
                Console.WriteLine("Condition three rignt");
            }
            else
            {
                Console.WriteLine("No one of the conditions ");
            }
            Console.ReadKey();
        }
    }
}

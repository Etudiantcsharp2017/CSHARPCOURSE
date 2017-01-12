using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversion_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            long myVar = 1000;
            float myVar2 = myVar;
            float myfloatVvar = 12.5f;
            int myInt2Var = myfloatVvar;                
            Console.WriteLine($"{myVar2}");
           // Console.WriteLine(myVar2);
            char myVar3= 'G';
            int myIntvar = myVar3;
            Console.WriteLine($"{myIntvar}");
            Console.ReadKey();
        }
    }
}

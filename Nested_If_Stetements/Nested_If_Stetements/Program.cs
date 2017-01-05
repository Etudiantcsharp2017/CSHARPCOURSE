using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Stetements
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 9, myVar2 = 6;
            if(myVar1==10)
            {
                Console.WriteLine("myVar equal 9 ");
                if (myVar2==7)
                {
                    Console.WriteLine("myVar ==7 ");
                }
                else
                {
                    Console.WriteLine("not equal myVar == 7");
                }
            }
            else
            {
                Console.WriteLine("not equal myVar ==9 ");
            }
            Console.ReadKey();
        }
    }
}

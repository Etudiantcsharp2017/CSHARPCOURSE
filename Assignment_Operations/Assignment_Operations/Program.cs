using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //=, += ,-=,*=,/=,%=
            //int myvar1 =7, myvar2 = 3;
            //myvar2 = myvar1;
            //myvar2 += myvar1; ///myvar1=myvar1+myvar2
            //myvar1 -= myvar2;//myvar1=myvar1-myvar2
            // myvar1 *= myvar2;//myvar1=myvar1*myvar2
            // myvar1 /= myvar2;//myvar1=myvar1/myvar2
            //myvar1 %= myvar2; //myvar1=myvar1%myvar2
            //Console.WriteLine( "Th Result is={0} the value of Var2 ={1}",myvar1,myvar2);
            ////////////////////////Q1
            int temp, myvar1 = 7, myvar2 = 2;
            myvar1 /= ++myvar2;
            Console.WriteLine("The result is {0}", myvar1);
            Console.ReadKey();

        }
    }
}

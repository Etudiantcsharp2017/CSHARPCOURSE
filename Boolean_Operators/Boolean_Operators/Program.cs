using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean Comparison ==,!=,<,>,<=,>=
            //Boolean Condition &&,||
            bool myresult;
            int myvar1 = 5, myvar2 = 2;
            myresult = myvar1 != 8;
            myresult = (myvar1 == 5) || (myvar2 == 8);
            Console.WriteLine("My result is = {0}",myresult);
            int mvar1 = 9, mvar2 = 11;bool test;
            test = (mvar1 < 10) && (mvar2 <= 11);
            Console.WriteLine("The result is ={0}", test);
            test= (mvar1 < 10) || (mvar2 <= 11);
            Console.WriteLine("The result is ={0}", test);
            Console.ReadKey();

        }
    }
}

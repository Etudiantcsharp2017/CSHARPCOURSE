using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Command_and_Challenge_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDoubleVar = 2500.45D;
            string myStringvar, mySubString;
            // myStringvar = myDoubleVar    //Implicit Conversion
            myStringvar = Convert.ToString(myDoubleVar);
            mySubString = myStringvar.Substring(0, 2);
            Console.WriteLine($"My varible is {myDoubleVar}\n");
            Console.WriteLine("My string Varible is {0} \n", myStringvar);
            Console.WriteLine("My Substring Varible is {0} \n", mySubString);
            ///////////////////////////////////////////////////////////////
            float myVarfloat = 45.56f;
            string myVarstring, mySubstring;
            myVarstring = Convert.ToString(myVarfloat);
            mySubstring = myVarstring.Substring(3, 2);
            Console.WriteLine("Float");
            Console.WriteLine("My string Varible is {0} \n", myVarstring);
            Console.WriteLine($"My varible Float is {myVarfloat}\n");
            Console.WriteLine("My Substring Varible is {0} \n", mySubstring);



            Console.ReadKey();
        }
    }
}

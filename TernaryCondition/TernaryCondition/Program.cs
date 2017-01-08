using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            // int myVar = 99;
            //   string myResult = (myVar < 10) ? "Less than 10" : "Gereater than 10 ";
            //// int myResult = (myVar < 10) ? 1 : 0;
            // Console.WriteLine("My variable Result is {0}", myResult);
            string myName = "kamel", result;
            result = (myName.Equals("kamel2")) ? "Yes" : "No";
            Console.WriteLine("My result is : {0}", result);
            Console.ReadKey();
        }
    }
}

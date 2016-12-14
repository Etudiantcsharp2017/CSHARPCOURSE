using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //+ - * / %
            int myvar1 = 15;
            int myvar2 = 10;
            int temp = myvar1 + myvar2;
            int temp2 = myvar1- myvar2;
            int temp3 = myvar1 * myvar2;
            float temp4 = myvar1 / myvar1;
            int temp5 = myvar1 % myvar2;

            //+ -
            int temp6 = +myvar1;
            int temp7 = -myvar1;
            string myStr= "This is wonderful";
            string myStr2 = "How is it ?";
            myStr = myStr + myStr2;
            Console.WriteLine("\nThe result1 + is {0}\nThe result2 - is {1}\nThe result3 * is {2}\nThe result4 / is {3}\nThe result5 % is {4}", temp,temp2,temp3,temp4,temp5);
            Console.WriteLine("{0}   {1}", temp6,temp7);
            Console.WriteLine("{0}",myStr);
            /////////////////////Q1
            int var1 = 7;int var2 = 3;
            int q1,q2,q3,q4;q1 = var1 + var2;q2 = var1 - var2;q3 = var1 / var2;q4 = var1 % var2;
            Console.WriteLine("+={0}\n-={1}\n/={2}\n%={3}",q1,q2,q3,q4);
            /////////////////////Q2
            string STR1 = "I am ";
            string STR2 = " Smart";
            STR1 = STR1 + STR2;
            Console.WriteLine("{0}", STR1);
            Console.ReadKey();
        }
    }
}

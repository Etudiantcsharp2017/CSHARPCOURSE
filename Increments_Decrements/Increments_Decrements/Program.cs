using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments_Decrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar1 = 2;
            int temp1 = myvar1--;
            Console.WriteLine("{0}", temp1);
            ////////////////////////////Q1 AND Q2/////////////
            int vaar1 = 5;
            int tmp1 = vaar1++;
            int tmp2 = ++vaar1;
            Console.WriteLine("{0}\n{1}\n", tmp1,tmp2);
            ///////////////////////Q3////////////
            int temp, mvar = 7, mvar2 = 2;
            temp = mvar-- / ++mvar2;

            //temp=7/3        mvar=7    mvar2=3   
            Console.WriteLine("Q3 >>>>  {0}", temp);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_and_Challange
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //double mySalary = 1020.30, total = 0.0;
            //while (i<15)
            //{
            //    total += mySalary;
            //    i++;
            //}
            //Console.WriteLine("My salary is {0} ", total);
            int i= 120,nbr=0;
            while (i>80)
            {
                i--;
                nbr++;
            }
            Console.WriteLine("Nombre d'exersices is {0} ", nbr);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //double mySalary = 1000.2, total = 0.0;
            //int i = 0;
            //do
            //{
            //    total += mySalary; //total= total +mysalary;
            //    i++;
            //    Console.WriteLine("i values equal {0} ",i);
            //    Console.WriteLine("Salary values equal {0} ", total);
            //} while (i<10);
            ////Console.WriteLine("Salary values equal {0} ", total);
            double mySalary = 1020;
            int i = 0;
            do
            {
                mySalary += 20;
                i++;
                Console.WriteLine("salary N° {0}  equal : {1}", i, mySalary);
            } while (mySalary<2000);
            int nby = i / 12;
            Console.WriteLine("Nembre d 'annees : {0}", nby);
            Console.ReadKey();
        }
    }
}

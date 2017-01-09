using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop_Break_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <=5; i++)
            //{

            //    if (i > 2) break;
            //    Console.WriteLine("Hello kamel");
            //    for (int j = 0; j <=4; j++)
            //    {
            //        Console.WriteLine("\tHello word");
            //    }
            //    Console.WriteLine("\n");
            //}
            int x =0;
            for (int i =1; i <= 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j == 7)
                        break;
                    x = j * i;
                    Console.WriteLine(x);

                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

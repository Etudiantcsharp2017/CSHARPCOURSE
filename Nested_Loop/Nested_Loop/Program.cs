using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Hello Kamel");
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.WriteLine("\tHello Word");

            //    }
            //    Console.WriteLine("\n");
            //}
            int x = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    x = i * j;
                    Console.WriteLine(x);
                }
                Console.WriteLine("\n");
            }
            x = 0;
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Paire");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j % 2 == 0)
                    {
                        x = i * j;
                        Console.WriteLine(x);
                    }
                }
                Console.WriteLine("\n");
            }
            x = 0;
            Console.WriteLine("\n\n\n");
            Console.WriteLine("ImpPaire");
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j % 2 != 0)
                    {
                        x = i * j;
                        Console.WriteLine(x);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}

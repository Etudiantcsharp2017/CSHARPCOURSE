using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchs_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myAnimal = "Cat";
            //switch (myAnimal)
            //{
            //    case "Canary":
            //        Console.WriteLine("my aanimal is Canary");
            //        break;
            //    case "Cat":
            //        Console.WriteLine("my aanimal is Cat");
            //        break;
            //    case "Camel":
            //        Console.WriteLine("my aanimal is Camel");
            //        break;
            //    default:
            //        Console.WriteLine("no one");
            //        break;
            //}
            string whatHesay = "Hello";
            switch (whatHesay)
            {
                case "hello":
                    Console.WriteLine("hello");
                    break;
                case "welcom":
                    Console.WriteLine("welcom");
                    break;
                case "Bey":
                    Console.WriteLine("Bey");
                    break;
                default:
                    Console.WriteLine("No One");
                    break;
            }
            Console.ReadKey();
        }
    }
}

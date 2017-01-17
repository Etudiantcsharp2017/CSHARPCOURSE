using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion_and_Overflow_case
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type1 = (Type1)Type2                  Casting
            byte Mysbyte;                           //0--255
            int myInt = 350;                         //000101011110           
          Mysbyte = (byte)myInt;                     //000011111111
                                                     //000001011110
            //float Mysbyte1;                           //0--255
            //int myInt1 = 300;
            //Mysbyte1 = myInt;
            //byte ch;
            //int str = 200;
            //ch = (byte)str;

            Console.WriteLine($"My varible Int = {myInt}"+"\n");
            Console.WriteLine($"My byt varible = {Mysbyte}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Char_StringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMax = char.MaxValue;
            int charMin = char.MinValue;

            char mychar = 'G';
            int convchtoint = Convert.ToInt32('G');
            Console.WriteLine("Min char ={0} Max char ={1} My Charachter ={2} My Conversion ={3}",charMin,charMax,mychar,convchtoint);
            string MyString = "This is my Varible";
            Console.WriteLine("\nMy String is {0}", MyString);

            bool MyBool = false;
            Console.WriteLine("My Boolean Value is {0}", MyBool);

            Console.ReadKey();
        }
    }
}

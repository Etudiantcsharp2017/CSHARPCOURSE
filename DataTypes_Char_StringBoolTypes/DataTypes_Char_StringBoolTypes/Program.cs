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

            //////////////////////////Q1 AND Q2 AND Q3 AND Q4/////////////////
            //Q1
            char chA = 'A';int ConvchA = Convert.ToInt32(chA);
            Console.WriteLine("Q1 The value of {0} in number is {1}", chA,ConvchA);
            //Q2
            char cha = 'a'; int Convcha = Convert.ToInt32(chA);
            Console.WriteLine("Q2 The value of {0} in number is {1}", cha, Convcha);
            //Q3
            string stvarA = "A";
            char convstrA = Convert.ToChar(stvarA);
            Console.WriteLine("Q3 This is my charachter {0}",convstrA);
            //Q4
            string stvara = "a";
            char convstra = Convert.ToChar(stvara);
            Console.WriteLine("Q4 This is my charachter {0}", convstra);
            //Q5
            char a, A;
            a = 'a';A = 'A';
            int na = Convert.ToInt32(a); int nA = Convert.ToInt32(A);
            Console.WriteLine("This is my charachter {0} Value {1} and This is my charachter {2} Value {3}", A,nA,a,na);
            Console.ReadKey();
        }
    }
}

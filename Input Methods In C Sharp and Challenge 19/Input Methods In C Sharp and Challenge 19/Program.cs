using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Methods_In_C_Sharp_and_Challenge_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReadLine , Read
            //string myName;
            //int myVar1, myVar2;
            //Console.WriteLine("Please Enter your Name\n");
            //myName = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Firts Number \n");
            //myVar1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your Entry ");
            //myVar2 = Console.Read();
            //Console.WriteLine($"Hello {myName}");
            //Console.WriteLine($"You Entred The Number {myVar1}");
            //Console.WriteLine($"You Entred The Entry {myVar2}");
            ///////////////Convertion///////////////////////
            //string v1, v2;
            //v1 = Convert.ToString(myVar1); v2 = Convert.ToString(myVar2);
            //Console.WriteLine($"Convertion \"1\" {v1} Convertion \"2\" {v2}");
            //Console.ReadKey();
            string First_Name, Last_Name;
            decimal Salary, TaxRate;
            Console.WriteLine("Please Enter your First Name :");
            First_Name = Console.ReadLine();
            Console.WriteLine("Please Enter your Last Name :");
            Last_Name = Console.ReadLine();
            Console.WriteLine("Please Enter your Salary :");
            Salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please Enter your TaxRate :");
            TaxRate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Welcome {First_Name} ,{Last_Name}");
            Console.WriteLine($"Your Salary For 12 Months is {(Salary * 12)- ((Salary * 12) * TaxRate)} ");
            Console.WriteLine($"Your paid TaxRate For 12 Months {(Salary*12)*TaxRate} ");
            Console.WriteLine("Good bye");


            Console.ReadKey();

        }
    }
}

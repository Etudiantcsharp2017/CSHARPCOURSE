using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            // \' \" \0 \a \b\n\r\t\v\f
            string myString = "Nazar \'said \"This is args good cours , and I think\a";
            string myString2 = @"D:\
                               MyProjetectCsharp";
            string mystring3 = myString + myString2;
            Console.WriteLine("{0}",mystring3);
            ///////////////////QUESTION////////////////////////
            //string TEST = "Nazar has said\"This is a unique course \", and I think so";
            string TEST = @"Nazar has said""This is a unique course "", and I think so";
            Console.WriteLine("{0}", TEST);
            string TEST2 = "Nazar \t'said \vThis is args good cours\f , and I think\a";
            Console.WriteLine("{0}", TEST2);
            Console.ReadKey();
        }
    }
}

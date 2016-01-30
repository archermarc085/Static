using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringMethods.Substring(2,5);
            Console.WriteLine();
            Console.WriteLine(StringMethods.IndexOf("l")); //  5
            Console.WriteLine(StringMethods.IndexOf("p")); // -1
            string oldValue = "docment";
            string newValue = "document";
            StringMethods.Replace(oldValue, newValue);
            Console.ReadLine();
        }

       
    }
}

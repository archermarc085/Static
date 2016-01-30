using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_3.Extensions;
namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 100, 12, 35, 16, 77, 99, 200, 300, 400, 11, 1, 0, -20, -100 };
            array.ShellSort(true);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}

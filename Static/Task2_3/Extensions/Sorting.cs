using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3.Extensions
{
   static class Sorting
    {
        public static IEnumerable<int> ShellSort(this int[] array)
        {
            int d = array.Length / 2;
            while (d > 0)
            {
                for (int i = 0; i < array.Length - d; i++)
                {
                    int j = i + d;
                    int temp = array[j];
                    while (j >= d && temp < array[j - d])
                    {
                        array[j] = array[j - d];
                        array[j - d] = temp;
                        j -= d;
                    }
                }
                d = d / 2;
            }
            return array;
        }

        public static IEnumerable<int> ShellSort(this int[] array, bool way)
        {
            int d = array.Length / 2;
            while (d > 0)
            {
                for (int i = 0; i < array.Length - d; i++)
                {
                    int j = i + d;
                    int temp = array[j];

                    if (way)
                    {
                        while (j >= d && temp < array[j - d]) //Ascending
                        {
                            array[j] = array[j - d];
                            array[j - d] = temp;
                            j -= d;
                        }
                    }
                    else
                    {
                        while (j >= d && temp > array[j - d]) //Descending
                        {
                            array[j] = array[j - d];
                            array[j - d] = temp;
                            j -= d;
                        }

                    }
                }
                d = d / 2;
            }
            return array;
        }
    }
}

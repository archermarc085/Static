using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
   static class StringMethods
    {
       public static string Replace(string oldValue, string newValue)
        {
            string document = "This docment uses 3 other docments to docment the documentation";
            Console.WriteLine(document);
            string[] array = document.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(oldValue))
                {
                    array[i] = newValue;
                }
            }
            string end = string.Join(" ", array);
            Console.WriteLine(end);
            return end;
        }

       public static int IndexOf(string str)
        {
            string animal = "animal";
            char index = Convert.ToChar(str);
            int count = 0;

            while (animal.Length > count)
            {
                if (animal[count].Equals(index))
                {
                    return count;
                }
                count++;
            }
            return -1;
        }
       public static string Substring(int position, int lenght)
        {
            string name = "This docment";//char[] name = {'T','h','i','s',...,'n','t' };
            char[] array = new char[name.Length];

            int count = 0;
            position++;
            while (count < lenght)
            {
                array[count] = name[position + count - 1];
                count++;
            }
            foreach (char item in array)
            {
                Console.Write(item);
            }
            return array.ToString();
        }
    }
}

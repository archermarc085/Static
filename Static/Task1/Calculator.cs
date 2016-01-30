using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   static class Calculator
    {
        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static int Subtract(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber - secondNumber;
            }
            return secondNumber - firstNumber;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new Exception("Divide by zero!");
            }
            else
            {
                return firstNumber / secondNumber;
            }
        }

        public static double Sum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static double Subtract(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber - secondNumber;
            }
            return secondNumber - firstNumber;
        }

        public static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static double Divide(double firstNumber, double secondNumber)
        {
            if (secondNumber == 0)
            {
                throw new Exception("Divide by zero!");
            }
            else
            {
                return firstNumber / secondNumber;
            }
        }
    }
}

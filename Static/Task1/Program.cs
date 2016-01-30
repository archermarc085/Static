using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    enum Sign { Sum, Subtract, Multiply, Divide }
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            string inputNumber = "";
            string inputNumber2 = "";


            Sign sign = Sign.Sum;
            firstNumber = inputNumber.CheckIntDigits();
            secondNumber = inputNumber2.CheckIntDigits();


            switch (sign)
            {
                case Sign.Sum:
                    {
                        int sum = Calculator.Sum(firstNumber, secondNumber);
                        Console.WriteLine("The sum is: " + sum.ToString());
                        break;
                    }
                case Sign.Subtract:
                    {
                        int difference = Calculator.Subtract(firstNumber, secondNumber);
                        Console.WriteLine("The difference is: " + difference.ToString());
                        break;
                    }
                case Sign.Multiply:
                    {
                        int product = Calculator.Multiply(firstNumber, secondNumber);
                        Console.WriteLine("The composition is: " + product.ToString());
                        break;
                    }
                case Sign.Divide:
                    {
                        int quotient = Calculator.Divide(firstNumber, secondNumber);
                        Console.WriteLine("The quotient is: " + quotient.ToString());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid operator.");
                        break;
                    }
            }


            Calc calc = new Calc(1, 80);
            Calc calc1 = new Calc(100, 10);
            Calc calc2 = calc - calc1;
            calc2.Show();

            Console.ReadLine();
        }
    }
}

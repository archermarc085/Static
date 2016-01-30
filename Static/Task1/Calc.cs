using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Calc
    {
        #region Fields
        int firstNumber = 0;
        int secondNumber = 0;
        #endregion

        #region Constructors
        public Calc(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }
        public Calc()
        {

        }
        #endregion

        #region Overloading operators

        public static Calc operator +(Calc t1, Calc t2)
        {
            return new Calc(t1.firstNumber + t2.firstNumber, t1.secondNumber + t2.secondNumber);
        }
        public static Calc operator -(Calc t1, Calc t2)
        {
            Calc calculator = new Calc();
            if ((t1.firstNumber > t2.firstNumber) && (t1.secondNumber > t2.secondNumber))
            {
                calculator.firstNumber = t1.firstNumber - t2.firstNumber;
                calculator.secondNumber = t1.secondNumber - t2.secondNumber;
                return calculator;
            }
            else if ((t1.firstNumber > t2.firstNumber) && (t1.secondNumber < t2.secondNumber))
            {
                calculator.firstNumber = t1.firstNumber - t2.firstNumber;
                calculator.secondNumber = t2.secondNumber - t1.secondNumber;
                return calculator;
            }
            else if ((t2.firstNumber > t1.firstNumber) && (t1.secondNumber < t2.secondNumber))
            {
                calculator.firstNumber = t2.firstNumber - t1.firstNumber;
                calculator.secondNumber = t2.secondNumber - t1.secondNumber;
                return calculator;
            }
            else if ((t2.firstNumber > t1.firstNumber) && (t1.secondNumber > t2.secondNumber))
            {
                calculator.firstNumber = t2.firstNumber - t1.firstNumber;
                calculator.secondNumber = t1.secondNumber - t2.secondNumber;
                return calculator;
            }
            else if ((t1.firstNumber == t2.firstNumber) && (t1.secondNumber < t2.secondNumber))
            {
                calculator.firstNumber = t1.firstNumber - t2.firstNumber;
                calculator.secondNumber = t2.secondNumber - t1.secondNumber;
                return calculator;
            }
            else if ((t1.firstNumber == t2.firstNumber) && (t1.secondNumber > t2.secondNumber))
            {
                calculator.firstNumber = t1.firstNumber - t2.firstNumber;
                calculator.secondNumber = t1.secondNumber - t2.secondNumber;
                return calculator;
            }
            else if ((t1.firstNumber > t2.firstNumber) && (t1.secondNumber == t2.secondNumber))
            {
                calculator.firstNumber = t1.firstNumber - t2.firstNumber;
                calculator.secondNumber = t2.secondNumber - t1.secondNumber;
                return calculator;
            }
            else
                calculator.firstNumber = t2.firstNumber - t1.firstNumber;
            calculator.secondNumber = t2.secondNumber - t1.secondNumber;
            return calculator;
        }

        public static Calc operator *(Calc t1, Calc t2)
        {
            return new Calc(t1.firstNumber * t2.firstNumber, t1.secondNumber * t2.secondNumber);
        }

        public static Calc operator /(Calc t1, Calc t2)
        {
            Calc calculator = new Calc();
            if (t2.firstNumber == 0 || t2.secondNumber == 0) { throw new Exception("Divide by zero!"); }
            return new Calc(t1.firstNumber / t2.firstNumber, t1.secondNumber / t2.secondNumber);
        }

        public static bool operator <(Calc t1, Calc t2)
        {
            return (t1.firstNumber + t2.secondNumber < t2.firstNumber + t2.secondNumber);
        }
        public static bool operator >(Calc t1, Calc t2)
        {
            return (t1.firstNumber + t2.secondNumber > t2.firstNumber + t2.secondNumber);
        }
        #endregion

        #region Methods
        public int Sum()
        {
            return firstNumber + secondNumber;
        }
        public int Subtract()
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber - secondNumber;
            }
            return secondNumber - firstNumber;
        }

        public int Multiply()
        {
            return firstNumber * secondNumber;
        }

        public int Divide()
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
        public void Show()
        {
            Console.WriteLine("firstNumber: {0} | secondNumber: {1}", firstNumber, secondNumber);
        }
        #endregion
    }
}

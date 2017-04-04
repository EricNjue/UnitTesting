using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class MathsClass
    {
        public int Add(int num1,int num2)
        {
            return num1+num2;
        }

        public int Multiply(int num1,int num2)
        {
            return num1 * num2;
        }

        public int Subtract(int num1,int num2)
        {
            return num1 - num2;
        }

        public int Division(int num1,int num2)
        {
            return num1 / num2;
        }
    }

    public class AdvancedMathsClass
    {
        public bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }
    }
}

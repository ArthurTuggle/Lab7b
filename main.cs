using System;

namespace exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a base: ");
            var baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter an exponent: ");
            var exponent = Convert.ToInt32(Console.ReadLine());

            var resultOfCalc = IntegerPower(baseNumber, exponent);
            Console.WriteLine("{0} to the power of {1} is {2}", baseNumber, exponent, resultOfCalc);
        }

        private static int IntegerPower(int baseNum, int expo)
        {
            var result = 1;
            for (var i = 0; i < expo; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}


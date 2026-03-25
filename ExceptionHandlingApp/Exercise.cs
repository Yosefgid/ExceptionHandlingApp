using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingApp
{
    internal class Exercise1
    {
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static void DivideUserInputs()
        {
            while (true)
            {
                try
                {
                    int[] numbers = GetUserInputs();
                    int result = Divide(numbers[0], numbers[1]);
                    Console.WriteLine($"Result:  {result}");
                    break; //Only exit the loop if the operation is successful
                }

                catch(FormatException)
                {
                    Console.WriteLine("Invalid input only integers allowed, Please try again.");
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Can not divide a zero. Please try again.");
                }
            }
        }
        private static int[] GetUserInputs()
        {
            Console.Write("Enter Divisor: ");
            //This is where our FormatException can happen as a user can input a string instead of any integer
            int divisor = int.Parse(Console.ReadLine());
            Console.Write("Enter Dividend: ");
            int dividend = int.Parse(Console.ReadLine());



            if (divisor < 0 || dividend < 0)
            {
                int count = 0;
                if (divisor < 0)
                {
                    count++;
                }
                if (dividend < 0)
                {
                    count++;
                }
                int[] values = new int[count];

                int i = 0;
                if (divisor < 0)
                {
                    values[i] = divisor;
                    i++;
                }
                if (dividend < 0)
                {
                    values[i] = dividend;
                }
                throw new NegativeIntegerInputException(values);
                }
                return new int[] { divisor, dividend };
        }
    }
}


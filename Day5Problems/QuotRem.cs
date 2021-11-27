using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class QuotRem
    {
        public void DisplayQuotRem()
        {
            int dividend, divisor;
            Console.Write("Enter a number as dividend: ");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number as divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend = " + dividend + " Divisor = " + divisor);
            Console.WriteLine("The quotient is: " + quotient);
            Console.WriteLine("The remainder is: " + remainder);
        }
    }
}

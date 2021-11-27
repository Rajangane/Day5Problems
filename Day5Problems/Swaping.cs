using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class Swaping
    {
        public void SwapNum()
        {
            int num1, num2;
            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping the numbers are: " + "Number1 = " + num1 + "," + " Number2 = " + num2);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After swapping the numbers are: " + "Number1 = " + num1 + "," + " Number2 = " + num2);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class LeapYear
    {
        public void CheackLeap()
        {
            int year;
            Console.WriteLine("Enter a year to check Leap year or not");
            year = Convert.ToInt32(Console.ReadLine());
            if (year < 1000 || year > 9999)
            {
                Console.WriteLine("U enterd wrong! Please a enter a 4 digit number");
            }
            else if ((year % 4) == 0 && (year % 100) != 0 || (year % 400) == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
    }
}

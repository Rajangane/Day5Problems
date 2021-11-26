using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class PowerOf
    {
        public void PowerOf2()
        {
            int n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            if (0 <= n && n < 31)
            {
                Console.WriteLine("The power's of 2 are:");
                for (int i = 0; i <= n; i++)
                {
                    Console.Write("");
                    Console.WriteLine((2 << i));
                }
            }
            else
            {
                Console.WriteLine("Integer can't take the power of 2 as bigger than 31, Enter smaller");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class HarmonicNum
    {
        public void DisplayHarmonic()
        {
            int num;
            double s = 0.0;
            Console.WriteLine(" enter nth number to print the harmonic series");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("U entered Zero(0)! Please enter a valid number");
            }
            for (int i = 1; i <= num; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }

        }
    }
}

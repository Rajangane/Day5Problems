using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    public class HeadTail
    {
        public void FlipCoinHeadTail()
        {
            int count = 100;
            double heads = 0;
            double tails = 0;

            for (int i = 1; i <= count; i++)
            {
                Random random = new Random();
                var n = random.NextDouble();
                if (n < 0.5)
                {
                    Console.WriteLine("Tail");
                    tails += 1;
                }
                else
                {
                    Console.WriteLine("Head");
                    heads += 1;
                }
            }
            Console.WriteLine("The percentage of Heads: " + (heads / count) * 100 + "%");
            Console.WriteLine("The percentage of Tails: " + (tails / count) * 100 + "%");
        }
}
}

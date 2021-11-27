using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Problems
{
    internal class Vowel
    {
        public void Vowel_Consonant()
        {
            char ch;
            Console.WriteLine("Enter a Alphabet to check Vowel or Consonant");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine("Entered alphabet " + ch + " is Vowel");
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("Entered alphabet " + ch + " is Consonant");
            }
            else
            {
                Console.WriteLine("U entered wrong, Please enter a alphabet");
            }
        }
    }
}

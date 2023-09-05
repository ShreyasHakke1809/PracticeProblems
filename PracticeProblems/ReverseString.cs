using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class ReverseString
    {
        public static void Reverse()
        {
            Console.WriteLine("Please give string");
            string input = Console.ReadLine();
            string reverse = string.Empty;
            int length = input.Length - 1;
            while(length >= 0)
            {
                reverse = reverse + input[length];
                length--;
            }
            Console.WriteLine(reverse);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Pattern
    {
        public static void Pattern1()
        {
             for (int i = 1; i<=8; i++)
             {
                for (int j = i; j <= 8; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

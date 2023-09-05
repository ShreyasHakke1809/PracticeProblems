using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class FindLowestElement
    {
        public static void FindLowest()
        {
            int i, low1, low2;
            Console.WriteLine("Please declare the size of array");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[num];

            Console.WriteLine("Please add elements in array");
            for (i = 0; i < num; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            low1 = a[0];
            low2 = a[0];
            for (i = 1; i < num; i++)
            {
                if (a[i] < low1)
                {
                    low2 = low1;
                    low1 = a[i];
                }
                else if (a[i] < low2 && a[i] != low1)
                {
                    low2 = a[i];
                }
            }
            Console.WriteLine("Min value of array is:" + low1," " +low2);
        }
    }
}
        
    


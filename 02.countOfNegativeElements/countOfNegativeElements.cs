using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.countOfNegativeElements
{
    class countOfNegativeElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] countNegativeElements = new int[n];
            int count = 0;

            for (int i = 0; i < countNegativeElements.Length; i++)
            {
                countNegativeElements[i] = int.Parse(Console.ReadLine());

                if (countNegativeElements[i]<0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

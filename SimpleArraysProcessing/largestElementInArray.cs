using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraysProcessing
{
    class largestElementInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfIntergers = new int[n];

            int largestElement = -100000000;
            for (int i = 0; i < n; i++)
            {
                arrayOfIntergers[i] = int.Parse(Console.ReadLine());
                
                if (arrayOfIntergers[i]>largestElement)
                {
                    largestElement = arrayOfIntergers[i];
                }
            }
            Console.WriteLine(largestElement);
        }
    }
}

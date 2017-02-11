using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.occurrencesOfLargerNumbers
{
    class occurrencesOfLargerNumbers
    {
        static void Main(string[] args)
        {
            var occurrencesOfLargerNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double n = double.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < occurrencesOfLargerNumbers.Length; i++)
            {
                if (occurrencesOfLargerNumbers[i]>n)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

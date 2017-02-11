using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.countOfGivenElement
{
    class countOfGivenElement
    {
        static void Main(string[] args)
        {
            var countGivenElement = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < countGivenElement.Length; i++)
            {
                if (countGivenElement[i] == n)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.equalSequenceOfElements
{
    public class equalSequenceOfElements
    {
        public static void Main()
        {
            var equalSequenceArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool areAllTrue = true;

            for (int i = 0; i < equalSequenceArray.Length-1; i++)
            {
                if (equalSequenceArray[i] !=equalSequenceArray[i+1])
                {
                    areAllTrue = false;
                    break;
                }
            }
            if (areAllTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

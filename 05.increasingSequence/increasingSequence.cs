using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.increasingSequence
{
    public class increasingSequence
    {
        public static void Main()
        {
            var increasingSequenceArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool IsIncreasingSequence = true;

            for (int i = 0; i < increasingSequenceArray.Length-1; i++)
            {
                if (increasingSequenceArray[i+1]<=increasingSequenceArray[i])
                {
                    IsIncreasingSequence = false;
                    break;
                }
            }

            if (IsIncreasingSequence)
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

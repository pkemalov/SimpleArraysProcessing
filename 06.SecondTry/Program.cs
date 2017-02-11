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

            int count = 0;
            for (int i = 0; i < increasingSequenceArray.Length; i++)
            {
                if (i > 0)
                {
                    if (increasingSequenceArray[i] == increasingSequenceArray[i - 1])
                    {
                        count++;
                    }

                }


            }
            if (count == increasingSequenceArray.Length - 1)
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

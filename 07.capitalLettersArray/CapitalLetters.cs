using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.capitalLettersArray
{
    public class CapitalLetters
    {
        public static void Main()
        {
            var capitalLetters = Console.ReadLine().Split(' ').ToArray();

            int count = 0;
            for (int i = 0; i < capitalLetters.Length; i++)
            {
                string currentWord = capitalLetters[i];

                if (currentWord.Length==1)
                {
                    char character = currentWord[0];
                    if (character>=65 && character <= 90)
                    {
                        count++;
                    }
                }
                
            }
            Console.WriteLine(count);
        }
    }
}

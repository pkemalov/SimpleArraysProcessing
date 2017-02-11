using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ballisticsTraining
{
    public class ballisticsTraining
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var x = 0;
            var y = 0;
            var secondArray = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < secondArray.Length; i++)
            {
                if (secondArray[i]== "right")
                {
                    var increaseX = int.Parse(secondArray[i + 1]);
                    x += increaseX; 
                }
                else if (secondArray[i] == "left")
                {
                    var decreaseX = int.Parse(secondArray[i + 1]);
                    x -= decreaseX;
                }
                else if (secondArray[i] == "up")
                {
                    var increaseY = int.Parse(secondArray[i + 1]);
                    y += increaseY;
                }
                else if (secondArray[i] == "down")
                {
                    var decreaseY = int.Parse(secondArray[i + 1]);
                    y -= decreaseY;
                }
            }

            if (x ==firstArray[0] && y == firstArray[1])
            {
                Console.WriteLine($"firing at [{x}, {y}]");
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{x}, {y}]");
                Console.WriteLine("better luck next time...");
            }

        }
    }
}

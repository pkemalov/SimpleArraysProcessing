using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.altitude
{
    public class altitude
    {
        public static void Main()
        {
            var altitude = Console.ReadLine().Split(' ').ToArray();

            var initialAltitude = double.Parse(altitude[0]);

            for (int i = 0; i < altitude.Length; i++)
            {
                if (altitude[i] == "up")
                {
                    var nextNumberUp = double.Parse(altitude[i + 1]);
                    initialAltitude += nextNumberUp;
                }
                else if (altitude[i] == "down")
                {
                    var nextNumberDown = double.Parse(altitude[i + 1]);
                    initialAltitude -= nextNumberDown;

                    if (initialAltitude <= 0)
                    {
                        Console.WriteLine("crashed");
                        break;
                    }
                }
            }

            if (initialAltitude > 0)
            {
                Console.WriteLine("got through safely. current altitude: {0}m", initialAltitude);
            }
        }
    }
}

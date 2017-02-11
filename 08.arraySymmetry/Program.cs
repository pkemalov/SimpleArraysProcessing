using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.arraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var arraySymmetry = Console.ReadLine().Split(' ').ToArray();

            int count = 0;
            for (int i = 0; i < arraySymmetry.Length; i++)
            {
                if (arraySymmetry[0] == arraySymmetry[arraySymmetry.Length-1] && arraySymmetry[1] == arraySymmetry[arraySymmetry.Length - 2])
                {
                    count++;
                    
                }
                
            }
            if (count==arraySymmetry.Length)
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

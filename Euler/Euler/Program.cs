using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LizHack's Section

            // stores the total/sum
            int Total = 0;

            // Find the sum of all the multiples of 3 or 5 below 1000.
            for (int i = 0; i < 1000; i++)
            {
                // if the current number doesn't have a remainder...
                if (((i % 3) == 0) || ((i % 5) == 0))
                    // Add it to the total
                    Total += i;
                
            }

            // print the result...
            Console.WriteLine($"The sum is: {Total}. \n\n\nPress enter to continue...");

            // "Pause" The program...
            Console.ReadLine();

            #endregion
        }
    }
}

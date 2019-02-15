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
            Console.WriteLine($"The sum is: {Total}. \n\n\nPress enter to exit...");

            // "Pause" The program...
            Console.ReadLine();

            #endregion


            int answer1 = 0;//To store the final sum of the saured values
            int count = 1;
            int answer2 = 0;//To store the final ssum of the natural numbers
            int final;//To store the final answer
            for (int stop = 0; stop < 100; stop++)//Loop to till 100 
            {
                answer1 = (count * count) + answer1;//sqauring
                answer2 = (count + answer2);//summing
                count++;
            }
            answer2 = answer2 * answer2;
            final = answer2 - answer1;
            Console.WriteLine($"Squares >> {answer1}");
            Console.WriteLine($"Sums >> {answer2}");
            Console.WriteLine($"Answer >> {final}");
            string v = Console.ReadLine();// puasing to see the answers

        }
    }
}

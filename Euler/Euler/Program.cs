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
<<<<<<< HEAD
            Console.WriteLine($"The sum is: {Total}. \n\n\nPress enter to exit...");
=======
            Console.WriteLine($"The sum is: {Total}. \n\n\nPress enter to continue...");
>>>>>>> 773c54a68166d56c6c2a24cd997253d9c5a7eb91

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

 

            double i = 1; //The number to be compared
            double num = 0; //A placeholder
            bool uptotwnety = false; //Will check if it's divisable up to 20
            while (true) //Infinte loop, breaks when number is found
            {
                for(int n = 1; n <21; n++) //Checks factors up to 20
                {
                    if (i % n == 0)
                    {
                        uptotwnety = true; //If it's divisable, it's true
                    }
                    else
                    {
                        uptotwnety = false; //If not, becomes fasle and jumps out of the loop
                        break;
                    }
                }
                if (uptotwnety) //If true at the end, the number is divisable by all up to 20
                {
                    num = i; //Assing it
                    break; //Break the loop
                }
                i++;
            }
            Console.WriteLine($"{num}");
            Console.ReadLine();


            //Robin's region
            double count = 1; //What will be divided
            bool uptotwenty = false; //Bool to check the number's eligability
            while (true)
            {
                for (int n = 1; n <= 20; n++) //Loop that divides the number by each number up to 20
                {
                    if (count % n == 0)
                    {
                        uptotwenty = true;
                    }
                    else
                    {
                        uptotwenty = false; //If a number isn't divisable by them all, the loop breaks
                        break;
                    }
                }
                if (uptotwenty) //Will be true if number was by divisable by every number
                {

                    break;
                }
                count++;
            }
            Console.WriteLine($"Smallest number divisable by 1-20 is: {count}");
            Console.ReadLine();


        }
    }
}
}

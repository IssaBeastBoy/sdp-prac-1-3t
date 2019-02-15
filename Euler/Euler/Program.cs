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
            int answer1 = 0;//To store the final sum of the saured values
            int count = 1;
            int answer2 = 0;//To store the final ssum of the natural numbers
            int final;//To store the final answer
            for(int stop=0; stop<100;stop++)//Loop to till 100 
            {
                answer1 = (count*count)+answer1;//sqauring
                answer2 = (count+answer2);//summing
                count++;
            }
            answer2 = answer2 * answer2;
            final = answer2 - answer1;
            Console.WriteLine($"Squares >> {answer1}");
            Console.WriteLine($"Sums >> {answer2}");
            Console.WriteLine($"Answer >> {final}");
            string v= Console.ReadLine();// puasing to see the answers

               }
    }
}

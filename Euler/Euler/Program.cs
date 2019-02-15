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

        }
    }
}

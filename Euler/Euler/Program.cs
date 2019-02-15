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
            //Robin's region
            double count = 1; //What will be divided
            bool uptotwenty = false; //Bool to check the number's eligability
            while (true)
            {
                for(int n= 1; n<=20; n++) //Loop that divides the number by each number up to 20
                {
                    if(count % n == 0)
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

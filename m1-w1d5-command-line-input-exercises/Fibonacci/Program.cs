using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        /*
         The Fibonacci numbers are the integers in the following sequence:  
	        0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
         By definition, the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is the sum of the previous two.
 
         Write a command line program which prompts the user for an integer value and display the Fibonacci sequence leading up to that number.
  
         C:\Users> Fiboncci
         Please enter the Fibonacci number: 25
         
         0, 1, 1, 2, 3, 5, 8, 13, 21
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Fibonacci number: ");
            int fibonacciNumber = int.Parse(Console.ReadLine());
            int prev = 0;
            int next = 1;
            int sum = 0;
            Console.Write("0, 1, ");
            for (int i = 0; i < fibonacciNumber; )
            {
                sum = prev + next;
                prev = next;
                next = sum;
                Console.Write("{0}" + ", ", sum);
                i = i + prev;

            }

        }
    }
}

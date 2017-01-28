using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechElevator.Classes;

namespace CalculatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator newCalc = new Calculator(5);

            Console.WriteLine("{0} plus 2 is {1}",
                newCalc.Result, newCalc.Add(2));

            Console.WriteLine("{0} Minus 2 is {1}",
               newCalc.Result, newCalc.Subtract(2));

            Console.WriteLine("{0} times 2 is {1}",
               newCalc.Result, newCalc.Multiply(2));

        }
    }
}

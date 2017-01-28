using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {
        public Calculator(int startingResult)
        {
            result = startingResult;
        }
        public int result = 0;
        /// property to access private methods
        /// Get and setter methods
        public int Result
        {
            get { return result; }
            set { result = value; }
        }

        // The add method adds addend to result and returns
        public int Add(int addEnd)
        {
            return result += addEnd;
        }

        // the subtract method returns result minus subtractend
        public int Subtract(int subtrahend)
        {
            return result -= subtrahend;
        }

        public int Multiply(int multiplier)
        {
            return result *= multiplier;
        }

        public int Power(int exponent)
        {
            double newResult = result;
            double newExp = exponent;
            newResult = Math.Pow(newResult, newExp);

            result = (int)newResult;
            return result;
        }


        public void Reset()
        {
            result = 0;
        }
    }
}

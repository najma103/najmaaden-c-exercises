using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string of odd length, return the string length 3 from its middle, so "Candy" yields "and". 
         The string length will be at least 3.
         middleThree("Candy") → "and"
         middleThree("and") → "and"
         middleThree("solving") → "lvi"
         */
        public string MiddleThree(string str)
        {
            int startIndex = 0; 
            if (str.Length > 10)
            {
                startIndex = ((str.Length / 3) + 1);
                return str.Substring(startIndex, 3);

            }
            if (str.Length > 5)
            {
                startIndex = ((str.Length + 1) / 3);
                return str.Substring(startIndex, 3);

            }
            else
            {
                if (str.Length == 5)
                {
                    return str.Substring(1, 3);
                }
                else
                {
                    return str;
                }
            }
            
        }
    }
}

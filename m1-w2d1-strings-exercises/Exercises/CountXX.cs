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
         Count the number of "xx" in the given string. We'll say that overlapping is allowed, so "xxx" contains 2 "xx".
         countXX("abcxx") → 1
         countXX("xxx") → 2
         countXX("xxxx") → 
         */
        public int CountXX(string str)
        {
            int countX = 0;
            int lastIndex = str.Length - 1;
            bool hasThreeX = false;

            string[] words = str.Split(' ');

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 'x')
                    {
                        countX += 1;
                    }
                }
                if(words.Length == 1)
                {
                    if (countX == 2)
                    {
                        return 1;
                    }
                    if (countX > 2)
                    {
                        return countX - 1;
                    }
                    else
                    {
                        return 0;
                    }
                 }
                 else
                 {
                    if (countX > 2)
                    {
                        return countX - 2;
                    }
                    else
                    {
                     return 0;
                    }
                 }
  
        }
    }
}

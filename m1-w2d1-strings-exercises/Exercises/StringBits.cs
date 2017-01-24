﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
         stringBits("Hello") → "Hlo"
         stringBits("Hi") → "H"
         stringBits("Heeololeo") → "Hello"
         */
        public string StringBits(string str)
        {
            int lastIndex = (str.Length - 1);
            string newStr = "";
            for (int i = 0; i < str.Length; i += 2)
            {
                if (i < lastIndex)
                {
                    newStr += (str.Substring(i, 1));
                }
                else
                {
                    newStr += (str.Substring(i, 1));

                }
            }

            return newStr;
        }
    }
}

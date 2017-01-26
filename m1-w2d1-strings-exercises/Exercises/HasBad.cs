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
         Given a string, return true if "bad" appears starting at index 0 or 1 in the string, such as with 
         "badxxx" or "xbadxx" but not "xxbadxx". The string may be any length, including 0. Note: use .equals()
         to compare 2 strings.
         hasBad("badxx") → true
         hasBad("xbadxx") → true
         hasBad("xxbadxx") → false
         */
        public bool HasBad(string str)
        {
            if (str.Length >= 4)
            {
                string firstFour = str.Substring(0, 4);
                bool containsBad = firstFour.Contains("bad");
                return containsBad;
            } else
            {
                if (str.Contains("bad"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 3 int values, a b c, return their sum. However, if one of the values is 13 then it does not 
         count towards the sum and values to its right do not count. So for example, if b is 13, then both 
         b and c do not count.
         luckySum(1, 2, 3) → 6
         luckySum(1, 2, 13) → 3
         luckySum(1, 13, 3) → 1
         */
        public int LuckySum(int a, int b, int c)
        {
            int sum = 0;
            if (!(a == 13))
            {
                sum += a;
            } else
            {
                sum += 0;
                return sum;
            }
            if (!(b == 13))
            {
                sum += b;
            } else
            {
                sum += 0;
                return sum;
            }
            if (!(c == 13))
            {
                sum += c;
            }
            else
            {
                sum += 0;
                return sum;
            }
            return sum;
        }
    }
}

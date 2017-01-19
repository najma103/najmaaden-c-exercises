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
         Given an array of ints length 3, figure out which is larger between the first and last elements 
         in the array, and set all the other elements to be that value. Return the changed array.
         maxEnd3([1, 2, 3]) → [3, 3, 3]
         maxEnd3([11, 5, 9]) → [11, 11, 11]
         maxEnd3([2, 11, 3]) → [3, 3, 3]
         */
        public int[] MaxEnd3(int[] nums)
        {
            int a = nums[0];
            int b = nums[2];
            if (a >= b)
            {
                for (int x = 0; x < nums.Length; x++)
                {
                    nums[x] = a;
                }
            } else
            {
                for (int x = 0; x < nums.Length; x++)
                {
                    nums[x] = b;
                }
            }
            return nums;
        }

    }
}

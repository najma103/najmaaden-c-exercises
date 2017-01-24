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
        Given a string, return a version where all the "x" have been removed. Except an "x" at the very start or end 
        should not be removed.
        stringX("xxHxix") → "xHix"
        stringX("abxxxcd") → "abcd"
        stringX("xabxxxcdx") → "xabcdx"
        */
        public string StringX(string str)
        {
            if (str.Length > 2)
            {
                string newStr = str.Substring(1, (str.Length - 2));
                newStr = newStr.Replace("x", "");
                string strFirst = str.Substring(0, 1);
                string strLast = str.Substring((str.Length - 1), 1);

                return strFirst + newStr + strLast;
            } else
            {
                return str;
            }

     
        }
    }
}

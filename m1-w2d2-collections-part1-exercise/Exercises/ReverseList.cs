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
         Given a List of string, return a new list in reverse order of the original. One obvious solution is to
         simply loop through the original list in reverse order, but see if you can come up with an alternative
         solution. (Hint: Think LIFO (i.e. stack))
         reverseList( ["purple", "green", "blue", "yellow", "green" ])  -> ["green", "yellow", "blue", "green", "purple" ]
         reverseList( ["jingle", "bells", "jingle", "bells", "jingle", "all", "the", "way"} )
            -> ["way", "the", "all", "jingle", "bells", "jingle", "bells", "jingle"]
         */
        public List<string> ReverseList(List<string> objectList)
        {
            Stack <string> newStr = new Stack<string>();
            List<string> listString = new List<string>();
            foreach (string element in objectList)
            {
                newStr.Push(element);
            }
            for (int i= 0; i < objectList.Count; i++)
            {
                listString.Add(newStr.Pop());
            }

            return listString;
           
        }

    }
}

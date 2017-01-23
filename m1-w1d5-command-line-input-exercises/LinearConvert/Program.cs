using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length: ");
            string strLenght = Console.ReadLine();
            int lenght;
            bool parsed = Int32.TryParse(strLenght, out lenght);
            
            Console.WriteLine("Is the measurement in (m)eter, or (f)eet? f or m?");
            string metric = Console.ReadLine();
           
            double meter, feet;
            if (parsed)
            {
                if (metric == "f" || metric == "F")
                {
                    meter =  (int)(lenght * 0.3048);
                    Console.WriteLine(lenght + "f  is "
                            + meter + "m.");
                }
                else if (metric == "m" || metric == "M")
                {
                    feet = (int)(lenght * 3.2808399);
                    Console.WriteLine(lenght + "m  is "
                            + feet + "f.");
                }
                else
                {
                    Console.WriteLine("Program does not recognize this character: " 
                                        + metric);
                }
            }
            else
            {
                Console.WriteLine("Program could not parse '{0}' to an int. ", strLenght);
            }

        }
    }
}

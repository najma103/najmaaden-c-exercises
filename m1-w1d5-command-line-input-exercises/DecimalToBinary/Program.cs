using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        /*
        Write a command line program which prompts the user for a series of decimal integer values  
        and displays each decimal value as itself and its binary equivalent

        C:\Users> DecimalToBinary
        
        Please enter in a series of decimal values (separated by spaces): 460 8218 1 31313 987654321
        
        460 in binary is 111001100
        8218 in binary is 10000000011010
        1 in binary is 1
        31313 in binary is 111101001010001
        987654321 in binary is 111010110111100110100010110001
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter decimal values, separated by space or comma ");
            string input = Console.ReadLine();
            char[] separator = { ' ', ',' };
            string[] splitValues = input.Split(separator);
            // numbers array

            for (int i = 0; i < splitValues.Length; i++)
            {
                
                int inputValue = int.Parse(splitValues[i]);
                Console.Write("Decimal Value:  " + inputValue);

                //convert from int to binary
                int remainder;
                string result = string.Empty;
                while (inputValue > 0)
                {
                    remainder = inputValue % 2;
                    inputValue = inputValue / 2;
                    result = remainder.ToString() + result; 

                }
                Console.WriteLine("  " +"Binary:  {0}", result);

            }




        }
    }
}

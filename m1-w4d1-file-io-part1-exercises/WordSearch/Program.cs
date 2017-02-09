using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WordSearch
{
    class Program
    {
        static string filePath = String.Empty;
        static string searchPhrase = String.Empty;
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

           
            Console.WriteLine("Please enter the full filepath");
            filePath = Console.ReadLine();
            Console.WriteLine("Please enter your Search phrase");
            searchPhrase = Console.ReadLine();

            List<string> listOfLines = new List<string>(readAndLoadFile(filePath));
            if (!String.IsNullOrEmpty(searchPhrase))
            {
                searchAndDisplay(listOfLines);
                Console.ReadKey();
            }

        }

        static void searchAndDisplay(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Contains(searchPhrase.ToLower()))
                {
                    Console.WriteLine(i + " . " + list[i]);
             
                }
            }
        }


        ///reads file and loads List collection with everyline in the file
        static List<string> readAndLoadFile(string filePath)
        {
            bool srcExists = File.Exists(filePath);
            // the individual lines in a collection.
            List<string> allLines = new List<string>();
            if (srcExists)
            {

                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        // Read the file until the end of the stream is reached
                        while (!sr.EndOfStream)
                        {
                            // Read in a single line
                            string line = sr.ReadLine();

                            // Add each line of the file to allLines collection
                            allLines.Add(line);

                        } //go to the next line until the end is reached
                    }
                }
                catch (IOException e) //catch a specific type of Exception
                {
                    Console.WriteLine("Error reading the file");
                    Console.WriteLine(e.Message);
                }
            } else
            {
                Console.WriteLine("Error invalid FilePath given ");
                Console.ReadKey();
            }
            return allLines;
            
        }
    }
}

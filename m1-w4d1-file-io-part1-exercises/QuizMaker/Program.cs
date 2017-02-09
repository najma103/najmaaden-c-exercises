using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace QuizMaker
{
    class Program
    {
        static string searchPhrase = String.Empty;
        static string filePath = @"C:\WordSearch\sample-quiz-file.txt";
        static void Main(string[] args)
        {
            List<string[]> quizBank = new List<string[]>(readAndLoadFile(filePath));
            foreach (string[] item in quizBank)
            {
                string q = item[0];
                Console.WriteLine(q);
                string correctAnswer = "";
                for (int i = 1; i < item.Length; i++)
                {
              
                    if (item[i].Contains("*"))
                    {
                        correctAnswer = item[i].Substring(0, item[i].Length - 1);
                        Console.WriteLine(i + ". " + correctAnswer);
                    } else
                    {
                        Console.WriteLine(i + ". " + item[i]);
                    }

                }
                Console.WriteLine("Please enter the correct Answer ");
                string userAnswer = Console.ReadLine();
                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("You are correct ");
                }
                else
                {
                    Console.WriteLine("Sorry Better luck next time");
                }
                Console.ReadLine();
            }

        }

        ///reads file and loads List collection with everyline in the file
        static List<string[]> readAndLoadFile(string filePath)
        {
            bool srcExists = File.Exists(filePath);
            // the individual lines in a collection.
            List<string[]> allLines = new List<string[]>();
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
                            string[] line = sr.ReadLine().Split('|');

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
            }
            else
            {
                Console.WriteLine("Error invalid FilePath given ");
                Console.ReadKey();
            }
            return allLines;

        }
    }
}

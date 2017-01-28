using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechElevator.Classes;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * These first three exercises do not provide tests. They idea behind providing it 
            * within a Console application is to allow you to see how to instantiate and interact
            * with classes that you define as part of the exercise.
            *
            * It is intentionally left open ended so that you can modify your class and then
            * see how the changes allow you to interact with it differently. 
            *
            * Go slow and note how the intellisense suggestions change based on the modifications you make
            * to the class file
            */

            // Instantiate a new company
            // e.g. Company variableName = new Company();

            // Try Setting the name of the Company
            // e.g. variableName.PropertyName = value

            // Try Getting the name of the Company
            // e.g. Console.WriteLine(variableName.PropertyName)
            // e.g. string name = variableName.PropertyName;

            // Try setting some of the other Company properties

            // If you implemented CompanySize as a calculated property are you able
            // to set the value or do you receive a compile error?

            // Does CompanySize and Profit return the correct value based on the other properties?

            // Try instantiating another company object and doing the same as above with it

            Company g1 = new Company();
            Company te = new Company();
            // Set the company name
            g1.Name = "Google";

            te.Name = "Tech Elevator";
            
            // print out the company name
            Console.WriteLine("The company name is: " + g1.Name);
            Console.WriteLine("The company name is: " + te.Name);

            // set and get number of employees
            g1.NumberOfEmployees = 5099;
            te.NumberOfEmployees = 15;

            Console.WriteLine(g1.Name + "  has " + g1.NumberOfEmployees + "  employees " 
                        + " and it's a " + g1.GetCompanySize() + " sized company");
            Console.WriteLine();
            Console.WriteLine(te.Name + "  has " + te.NumberOfEmployees + "  employees "
            + " and it's a " + te.GetCompanySize() + " sized company");


            // Set and get company revenue
            g1.Revenue = 50000;
            Console.WriteLine(g1.Name + " had revenue of: " + g1.Revenue);

            // Set and get company expenses
            g1.Expenses = 23000;
            Console.WriteLine(g1.Name + " had exense of: " + g1.Expenses);

            // Calculate company profit as revenue - expenses. 

            Console.WriteLine(g1.Name + " had a " + g1.GetProfit() + " profit!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Company
    {
        public string name;
        /// <summary>
        /// Gets and sets the name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int numberOfEmployees;
        /// <summary>
        /// Gets and sets the numberOfEmployees
        /// </summary>
        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set { numberOfEmployees = value; }
        }
        public decimal revenue;
        /// <summary>
        /// Gets and sets the revenue
        /// </summary>
        public decimal Revenue
        {
            get { return revenue; }
            set { revenue = value; }
        }
        public decimal expenses;
        /// <summary>
        /// Gets and sets the expenses
        /// </summary>
        public decimal Expenses
        {
            get { return expenses; }
            set { expenses = value; }
        }

        /// company size - returns string
        public string GetCompanySize()
        {
            if (numberOfEmployees > 250)
            {
                return "large";
            }
            else if (numberOfEmployees >= 50 && numberOfEmployees <= 250)
            {
                return "medium";
            }
            else
            {
                return "small";
            }
        }
        /// method calculates company provit and returns profit in decimal
        public decimal GetProfit()
        {
            return (revenue - expenses);
        }
    }/// end of class
}

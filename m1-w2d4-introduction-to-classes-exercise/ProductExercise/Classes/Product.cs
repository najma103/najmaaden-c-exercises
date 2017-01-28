using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    public class Product
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

        public decimal price;
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public double weightInOunces;
        /// <summary>
        /// Gets and sets the weightInOunces
        /// </summary>
        public double WeightInOunces
        {
            get { return weightInOunces; }
            set { weightInOunces = value; }
        }
    }
}

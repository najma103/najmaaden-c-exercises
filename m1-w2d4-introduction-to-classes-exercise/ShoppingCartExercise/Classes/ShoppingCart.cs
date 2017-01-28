using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// A shopping cart class stores items in it.
    /// </summary>
    public class ShoppingCart
    {
        public int totalNumberOfItems;
        public double totalAmountOwed;

        public double GetAveragePricePerItem()
        {
            if (totalNumberOfItems > 0 && totalAmountOwed > 0)
            {
                double avgPricePerItem =
               (double)(totalAmountOwed / totalNumberOfItems);
                return avgPricePerItem;
            } else
            {
                return 0.0;
            }

        }
        public void AddItems(int numberOfItems, double pricePerItem)
        {
            totalNumberOfItems += numberOfItems;
            totalAmountOwed = totalNumberOfItems * pricePerItem;
        }

        public void Empty()
        {
            totalNumberOfItems = 0;
            totalAmountOwed = 0;
        }

    }
}

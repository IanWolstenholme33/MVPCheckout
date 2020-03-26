using Kata.Interfaces;
using Kata.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Classes
{
    public class Scanner : IPrice
    {
        public decimal GetPrice(Item item)
        {
            if (item.Product == "A99" && item.Quantity == 3)
            {
                return Convert.ToDecimal(1.30);
            }
            else if (item.Product == "A99" && item.Quantity < 3)
            {
                return Convert.ToDecimal(0.50 * item.Quantity); 
            }

            return 0;
        }
    }
}

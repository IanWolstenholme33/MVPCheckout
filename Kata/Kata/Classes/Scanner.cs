using Kata.Enum;
using Kata.Factory;
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
            if (item == null || item == default(Item))
            {
                return 0m;
            }
            var _priceFactory = new PriceFactory(item);
            var price = _priceFactory.GetDiscount();
            return Math.Round(item.Quantity * price,1);
        }
    }
}

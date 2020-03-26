using Kata.Enum;
using Kata.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Factory
{
    public class PriceFactory
    {
        private Item item;

        public PriceFactory(Item item)
        {
            this.item = item;
        }

        public decimal GetDiscount()
        {
            if (item.Product == ProductEnum.A99 && item.Quantity == 3)
            {
                return Convert.ToDecimal(1.30 / item.Quantity);
            }
            else if (item.Product == ProductEnum.A99 && item.Quantity < 3)
            {
                return Convert.ToDecimal(0.50 * item.Quantity);
            }

            return 0m;
        }
    }
}

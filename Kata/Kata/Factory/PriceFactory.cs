using Kata.Enum;
using Kata.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Factory
{
    public class PriceFactory
    {
        private Item _item;

        public PriceFactory(Item item)
        {
            this._item = item;
        }

        public decimal GetDiscount()
        {
            if (_item.Product == ProductEnum.A99 && _item.Quantity == 3)
            {
                return Convert.ToDecimal(1.30 / _item.Quantity);
            }
            else if (_item.Product == ProductEnum.A99 && _item.Quantity < 3)
            {
                return Convert.ToDecimal(0.50 * _item.Quantity);
            }

            return 0m;
        }
    }
}

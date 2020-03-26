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
            int discountedItems = 0;
            decimal total = 0m;
            switch (_item.Product)
            {
                case ProductEnum.A99:
                    discountedItems = Convert.ToInt32(Math.Floor(Convert.ToDecimal(_item.Quantity / 3)));
                    if (discountedItems > 0)
                    {
                        total = Convert.ToDecimal(1.3 * discountedItems);
                        var newQty = _item.Quantity - (discountedItems * 3);
                        return total + Convert.ToDecimal(newQty * 0.50);
                    }
                    else
                    {
                        return Convert.ToDecimal(_item.Quantity * 0.50);
                    }
                case ProductEnum.B15:
                    discountedItems = Convert.ToInt32(Math.Floor(Convert.ToDecimal(_item.Quantity / 2)));
                    if (discountedItems > 0)
                    {
                        total = Convert.ToDecimal(0.45 * discountedItems);
                        var newQty = _item.Quantity - (discountedItems * 2);
                        return total + Convert.ToDecimal(newQty * 0.30);
                    }
                    else
                    {
                        return Convert.ToDecimal(_item.Quantity * 0.30);
                    }
                case ProductEnum.C40:
                    return Convert.ToDecimal(_item.Quantity * 0.60);
                default:
                    return 0m;
            }
        }
    }
}

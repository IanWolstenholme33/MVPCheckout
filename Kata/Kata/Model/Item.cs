using Kata.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Model
{
    public class Item
    {
        public ProductEnum Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}

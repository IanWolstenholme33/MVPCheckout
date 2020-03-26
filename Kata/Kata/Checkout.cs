using Kata.Classes;
using Kata.Model;
using System;

namespace Kata
{
    public class Checkout
    {
        private Scanner _scanner;
        private Item _item;
     
        public Checkout(Item item)
        {
            this._item = item;
            this._scanner = new Scanner();
        }

        public decimal Total()
        {
            return _scanner.GetPrice(_item);
        }

    }
}

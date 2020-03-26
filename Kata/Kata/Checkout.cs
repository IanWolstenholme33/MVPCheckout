using Kata.Classes;
using Kata.Model;
using System;

namespace Kata
{
    public class Checkout
    {
        private Scanner _scanner;
        private Item _item;
        //to do or refactor ideas
        //introduce the capability to scan multiple items
        //introduce more dependency injection with a new interface probably a discount interface using niject to derive the class.
        //introduce a front end to be able to scan items.
        //add the possibility eg a look up file database or a lookup file maybe

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

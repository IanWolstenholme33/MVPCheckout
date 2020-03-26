using Kata.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.Interfaces
{
    public interface IPrice
    {
        decimal GetPrice(Item item);
    }
}

using Kata.Classes;
using Kata.Model;
using NUnit.Framework;

namespace KataTest
{
    public class Tests
    {
        private const decimal A99_QTY_THREE_TOTAL = 1.3m;

        [Test]
        public void TestDiscountSuccuss()
        {
            Item _item = new Item();
            _item.Product = "A99";
            _item.Quantity = 3;
            var _scan = new Scanner();
            decimal _totalprice = _scan.GetPrice(_item);
            Assert.AreEqual(_totalprice, A99_QTY_THREE_TOTAL);
        }
    }
}
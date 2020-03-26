using Kata.Classes;
using Kata.Enum;
using Kata.Model;
using NUnit.Framework;

namespace KataTest
{
    public class Tests
    {
        private const decimal A99_QTY_THREE_TOTAL = 1.3m;
        private const decimal B15_QTY_TWO_TOTAL = 0.45m;

        [Test]
        public void TestDiscountA99Success()
        {
            Item _item = new Item();
            _item.Product = ProductEnum.A99;
            _item.Quantity = 3;
            var _scan = new Scanner();
            decimal _totalprice = _scan.GetPrice(_item);
            Assert.AreEqual(_totalprice, A99_QTY_THREE_TOTAL);
        }

        [Test]
        public void TestDiscountNULLError()
        {
            Item _item = null;        
            var _scan = new Scanner();
            decimal _totalprice = _scan.GetPrice(_item);
            Assert.AreEqual(_totalprice, 0m);
        }

        [Test]
        public void TestDiscountB15Success()
        {
            Item _item = new Item();
            _item.Product = ProductEnum.B15;
            _item.Quantity = 2;
            var _scan = new Scanner();
            decimal _totalprice = _scan.GetPrice(_item);
            Assert.AreEqual(_totalprice, B15_QTY_TWO_TOTAL);
        }
    }
}
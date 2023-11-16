using Algorithm.Easy;
using Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Easy
{
    public class PlusOneTests
    {
        private PlusOne _member;

        [SetUp]
        public void SetUp()
        {
            _member = new PlusOne();
        }

        /// <summary>
        /// 1 <= digits.length <= 100
        /// 0 <= digits[i] <= 9
        /// digits does not contain any leading 0's.
        /// <summary>
        [Test]
        public void Plus()
        {
            int[] digits1 = new int[] { 1, 2, 3 };
            int[] digits2 = new int[] { 4, 3, 2, 1 };
            int[] digits3 = new int[] { 9 };
            int[] digits4 = new int[] { 9, 9, 9, 9, 9 };
            int[] digits5 = new int[] { 8, 9, 9, 9, 9 };
            int[] digits6 = new int[] { 1, 5, 3, 9, 5, 9 };
            int[] digits7 = new int[] { 1 };
            int[] expected1 = new int[] { 1, 2, 4 };
            int[] expected2 = new int[] { 4, 3, 2, 2 };
            int[] expected3 = new int[] { 1, 0 };
            int[] expected4 = new int[] { 1, 0, 0, 0, 0, 0 };
            int[] expected5 = new int[] { 9, 0, 0, 0, 0 };
            int[] expected6 = new int[] { 1, 5, 3, 9, 6, 0 };
            int[] expected7 = new int[] { 2 };
            Assert.AreEqual(MyFormat.Convert(expected1), MyFormat.Convert(_member.Plus(digits1)));
            Assert.AreEqual(MyFormat.Convert(expected2), MyFormat.Convert(_member.Plus(digits2)));
            Assert.AreEqual(MyFormat.Convert(expected3), MyFormat.Convert(_member.Plus(digits3)));
            Assert.AreEqual(MyFormat.Convert(expected4), MyFormat.Convert(_member.Plus(digits4)));
            Assert.AreEqual(MyFormat.Convert(expected5), MyFormat.Convert(_member.Plus(digits5)));
            Assert.AreEqual(MyFormat.Convert(expected6), MyFormat.Convert(_member.Plus(digits6)));
            Assert.AreEqual(MyFormat.Convert(expected7), MyFormat.Convert(_member.Plus(digits7)));
        }

        [Test]
        public void PlusV2Test()
        {
            int[] digits1 = new int[] { 1, 2, 3 };
            int[] digits2 = new int[] { 4, 3, 2, 1 };
            int[] digits3 = new int[] { 9 };
            int[] digits4 = new int[] { 9, 9, 9, 9, 9 };
            int[] digits5 = new int[] { 8, 9, 9, 9, 9 };
            int[] digits6 = new int[] { 1, 5, 3, 9, 5, 9 };
            int[] digits7 = new int[] { 1 };
            int[] expected1 = new int[] { 1, 2, 4 };
            int[] expected2 = new int[] { 4, 3, 2, 2 };
            int[] expected3 = new int[] { 1, 0 };
            int[] expected4 = new int[] { 1, 0, 0, 0, 0, 0 };
            int[] expected5 = new int[] { 9, 0, 0, 0, 0 };
            int[] expected6 = new int[] { 1, 5, 3, 9, 6, 0 };
            int[] expected7 = new int[] { 2 };
            Assert.AreEqual(MyFormat.Convert(expected1), MyFormat.Convert(_member.PlusV2(digits1)));
            Assert.AreEqual(MyFormat.Convert(expected2), MyFormat.Convert(_member.PlusV2(digits2)));
            Assert.AreEqual(MyFormat.Convert(expected3), MyFormat.Convert(_member.PlusV2(digits3)));
            Assert.AreEqual(MyFormat.Convert(expected4), MyFormat.Convert(_member.PlusV2(digits4)));
            Assert.AreEqual(MyFormat.Convert(expected5), MyFormat.Convert(_member.PlusV2(digits5)));
            Assert.AreEqual(MyFormat.Convert(expected6), MyFormat.Convert(_member.PlusV2(digits6)));
            Assert.AreEqual(MyFormat.Convert(expected7), MyFormat.Convert(_member.PlusV2(digits7)));
        }
    }
}


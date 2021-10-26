using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmSln;
using NUnit.Framework;

namespace AlorithmTests.Easy
{
    public class RevertIntegerTests
    {
        private RevertInteger _member;

        [SetUp]
        public void Setup()
        {
            _member = new RevertInteger();
        }

        [Test]
        public void RevertIntegerTest()
        {
            int num1 = 123;
            int num2 = -123;
            int num3 = 120;
            int num4 = 0;
            int num5 = 1534236469;
            int num6 = 2147483647;
            int num7 = -2147483647;
            int num8 = -2147483648;
            int expected_border = 0;
            int expected1 = 321;
            int expected2 = -321;
            int expected3 = 21;
            int expected4 = 0;
            int expected6 = -1;
            Assert.AreEqual(expected1,_member.Reverse(num1));
            Assert.AreEqual(expected2, _member.Reverse(num2));
            Assert.AreEqual(expected3, _member.Reverse(num3));
            Assert.AreEqual(expected4, _member.Reverse(num4));
            Assert.AreEqual(expected_border, _member.Reverse(num5));
            Assert.AreEqual(expected_border, _member.Reverse(num6));
            Assert.AreEqual(expected_border, _member.Reverse(num7));
            Assert.AreEqual(expected_border, _member.Reverse(num8));
        }
    }
}

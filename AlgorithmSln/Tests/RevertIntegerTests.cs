using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmSln;
using NUnit.Framework;

namespace Tests
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
            int expected1 = 321;
            int expected2 = -321;
            int expected3 = 21;
            int expected4 = 0;
            Assert.AreEqual(_member.Reverse(num1), expected1);
            Assert.AreEqual(_member.Reverse(num2), expected2);
            Assert.AreEqual(_member.Reverse(num3), expected3);
            Assert.AreEqual(_member.Reverse(num4), expected4);
        }
    }
}

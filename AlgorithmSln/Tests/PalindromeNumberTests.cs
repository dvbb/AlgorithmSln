using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmSln;
using NUnit.Framework;

namespace AlgorithmTests
{
    public class PalindromeNumberTests
    {
        private PalindromeNumber _member;
        [SetUp]
        public void Setup()
        {
            _member = new PalindromeNumber();
        }

        [Test]
        public void PalindromeNumberTest()
        {
            int num1 = 121;
            int num2 = -121;
            int num3 = 10;
            int num4 = 15688651;
            Assert.AreEqual(_member.IsPalindrome(num1), true);
            Assert.AreEqual(_member.IsPalindrome(num2), false);
            Assert.AreEqual(_member.IsPalindrome(num3), false);
            Assert.AreEqual(_member.IsPalindrome(num4), true);
        }
    }
}

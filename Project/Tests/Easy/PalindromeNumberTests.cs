using System;
using System.Collections.Generic;
using System.Text;
using AlgorithmSln;
using NUnit.Framework;

namespace AlorithmTests.Easy
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
            int num5 = 0;
            Assert.AreEqual(true, _member.IsPalindrome(num1));
            Assert.AreEqual(false, _member.IsPalindrome(num2));
            Assert.AreEqual(false, _member.IsPalindrome(num3));
            Assert.AreEqual(true, _member.IsPalindrome(num4));
            Assert.AreEqual(true, _member.IsPalindrome(num5));
        }

        [Test]
        public void PalindromeNumberV2Test()
        {
            int num1 = 121;
            int num2 = -121;
            int num3 = 10;
            int num4 = 15688651;
            int num5 = 0;
            Assert.AreEqual(true, _member.IsPalindromeV2(num1));
            Assert.AreEqual(false, _member.IsPalindromeV2(num2));
            Assert.AreEqual(false, _member.IsPalindromeV2(num3));
            Assert.AreEqual(true, _member.IsPalindromeV2(num4));
            Assert.AreEqual(true, _member.IsPalindromeV2(num5));
        }
    }
}

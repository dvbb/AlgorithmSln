using Algorithm.Medium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
{
    public class LongestPalindromicSubstringTests
    {
        LongestPalindromicSubstring _member;
        [SetUp]
        public void SetUp()
        {
            _member = new LongestPalindromicSubstring();
        }

        [Test]
        public void LongestPalindrome()
        {
            string input1 = "babad";
            string input2 = "cbbd";
            string input3 = "a";
            string input4 = "ac";
            string input5 = "";
            string input6 = "aaaaaa";
            string input7 = "cabacddae";
            string expect1 = "bab"; //"bab" or "aba"
            string expect2 = "bb";
            string expect3 = "a";
            string expect4 = "a";
            string expect5 = "";
            string expect6 = "aaaaaa";
            string expect7 = "cabac";
            Assert.AreEqual(expect1,_member.LongestPalindrome(input1));
            Assert.AreEqual(expect2,_member.LongestPalindrome(input2));
            Assert.AreEqual(expect3,_member.LongestPalindrome(input3));
            Assert.AreEqual(expect4,_member.LongestPalindrome(input4));
            Assert.AreEqual(expect5, _member.LongestPalindrome(input5));
            Assert.AreEqual(expect6, _member.LongestPalindrome(input6));
            Assert.AreEqual(expect7, _member.LongestPalindrome(input7));
        }
    }
}

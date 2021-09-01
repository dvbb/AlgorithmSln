using AlgorithmSln;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTests
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        private LongestSubstringWithoutRepeatingCharacters _member;
        [SetUp]
        public void Setup()
        {
            _member = new LongestSubstringWithoutRepeatingCharacters();
        }

        [Test]
        public void LongestSubstringWithoutRepeatingCharactersTest()
        {
            string str1 = "abcabcbb";
            string str2 = "bbbbb";
            string str3 = "pwwkew";
            string str4 = "";
            string str5 = "abv";
            string str6 = "aab";
            int expected1 = 3;
            int expected2 = 1;
            int expected3 = 3;
            int expected4 = 0;
            int expected5 = 3;
            int expected6 = 2;
            Assert.AreEqual(_member.LengthOfLongestSubstring(str1), expected1);
            Assert.AreEqual(_member.LengthOfLongestSubstring(str2), expected2);
            Assert.AreEqual(_member.LengthOfLongestSubstring(str3), expected3);
            Assert.AreEqual(_member.LengthOfLongestSubstring(str4), expected4);
            Assert.AreEqual(_member.LengthOfLongestSubstring(str5), expected5);
            Assert.AreEqual(_member.LengthOfLongestSubstring(str6), expected6);
        }
    }
}

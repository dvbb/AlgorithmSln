using AlgorithmSln;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
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
            Assert.AreEqual(expected1, _member.LengthOfLongestSubstring(str1));
            Assert.AreEqual(expected2, _member.LengthOfLongestSubstring(str2));
            Assert.AreEqual(expected3, _member.LengthOfLongestSubstring(str3));
            Assert.AreEqual(expected4, _member.LengthOfLongestSubstring(str4));
            Assert.AreEqual(expected5, _member.LengthOfLongestSubstring(str5));
            Assert.AreEqual(expected6, _member.LengthOfLongestSubstring(str6));
        }

        [Test]
        public void LongestSubstringWithoutRepeatingCharactersV2Test()
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
            Assert.AreEqual(expected1, _member.LengthOfLongestSubstringV2(str1));
            Assert.AreEqual(expected2, _member.LengthOfLongestSubstringV2(str2));
            Assert.AreEqual(expected3, _member.LengthOfLongestSubstringV2(str3));
            Assert.AreEqual(expected4, _member.LengthOfLongestSubstringV2(str4));
            Assert.AreEqual(expected5, _member.LengthOfLongestSubstringV2(str5));
            Assert.AreEqual(expected6, _member.LengthOfLongestSubstringV2(str6));
        }

        [Test]
        public void LongestSubstringWithoutRepeatingCharactersV3_QueueTest()
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
            Assert.AreEqual(expected1, _member.LengthOfLongestSubstringV3_Queue(str1));
            Assert.AreEqual(expected2, _member.LengthOfLongestSubstringV3_Queue(str2));
            Assert.AreEqual(expected3, _member.LengthOfLongestSubstringV3_Queue(str3));
            Assert.AreEqual(expected4, _member.LengthOfLongestSubstringV3_Queue(str4));
            Assert.AreEqual(expected5, _member.LengthOfLongestSubstringV3_Queue(str5));
            Assert.AreEqual(expected6, _member.LengthOfLongestSubstringV3_Queue(str6));
        }
    }
}

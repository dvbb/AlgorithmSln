using Algorithm.Easy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Easy
{
    public class LongestCommonPrefixTests
    {
        private LongestCommonPrefix _member;

        [SetUp]
        public void SetUp()
        {
            _member = new LongestCommonPrefix();
        }

        /// <summary>
        /// 1 <= strs.length <= 200
        /// 0 <= strs[i].length <= 200
        /// strs[i] consists of only lower-case English letters.
        /// </summary>
        [Test]
        public void GetLongestCommonPrefix()
        {
            string[] strs1 = new string[] { "flower", "flow", "flight" };
            string[] strs2 = new string[] { "dog", "racecar", "car" };
            string[] strs3 = new string[] { "dog"};
            string[] strs4 = new string[] { ""};
            string[] strs5 = new string[] { "ab","a"};
            string[] strs6 = new string[] { "reflower", "flow", "flight" };
            string expected1 = "fl";
            string expected2 = "";
            string expected3 = "dog";
            string expected4 = "";
            string expected5 = "a";
            string expected6 = "";
            Assert.AreEqual(expected1, _member.GetLongestCommonPrefix(strs1));
            Assert.AreEqual(expected2, _member.GetLongestCommonPrefix(strs2));
            Assert.AreEqual(expected3, _member.GetLongestCommonPrefix(strs3));
            Assert.AreEqual(expected4, _member.GetLongestCommonPrefix(strs4));
            Assert.AreEqual(expected5, _member.GetLongestCommonPrefix(strs5));
            Assert.AreEqual(expected6, _member.GetLongestCommonPrefix(strs6));
        }
    }
}

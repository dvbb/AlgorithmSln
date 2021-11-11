using Algorithm.Easy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Easy
{
    public class Implement_strStrTests
    {
        private Implement_strStr _member;

        [SetUp]
        public void SetUp()
        {
            _member = new Implement_strStr();
        }

        /// <summary>
        /// 0 <= haystack.length, needle.length <= 5 * 104
        /// haystack and needle consist of only lower-case English characters.
        /// </summary>
        [Test]
        public void strStr()
        {
            string haystack1 = "hello", needle1 = "ll";
            string haystack2 = "aaaaa", needle2 = "bba";
            string haystack3 = "",needle3 = "";
            string haystack4 = "",needle4 = "adx";
            string haystack5 = "dfs",needle5 = "";
            string haystack6 = "abccdsccx",needle6 = "ccx";
            string haystack7 = "avvbvvcsxcxdfvvbvvxs",needle7 = "avv";
            Assert.AreEqual(2,_member.StrStr(haystack1,needle1));
            Assert.AreEqual(-1,_member.StrStr(haystack2,needle2));
            Assert.AreEqual(0,_member.StrStr(haystack3,needle3));
            Assert.AreEqual(-1,_member.StrStr(haystack4,needle4));
            Assert.AreEqual(0,_member.StrStr(haystack5,needle5));
            Assert.AreEqual(6,_member.StrStr(haystack6,needle6));
            Assert.AreEqual(0,_member.StrStr(haystack7,needle7));
        }

        [Test]
        public void strStrV2_KMP()
        {
            string haystack1 = "hello", needle1 = "ll";
            string haystack2 = "aaaaa", needle2 = "bba";
            string haystack3 = "", needle3 = "";
            string haystack4 = "", needle4 = "adx";
            string haystack5 = "dfs", needle5 = "";
            string haystack6 = "abccdsccx", needle6 = "ccx";
            string haystack7 = "avvbvvcsxcxdfvvbvvxs", needle7 = "avv";
            Assert.AreEqual(2, _member.StrStrV2(haystack1, needle1));
            Assert.AreEqual(-1, _member.StrStrV2(haystack2, needle2));
            Assert.AreEqual(0, _member.StrStrV2(haystack3, needle3));
            Assert.AreEqual(-1, _member.StrStrV2(haystack4, needle4));
            Assert.AreEqual(0, _member.StrStrV2(haystack5, needle5));
            Assert.AreEqual(6, _member.StrStrV2(haystack6, needle6));
            Assert.AreEqual(0, _member.StrStrV2(haystack7, needle7));
        }
    }
}

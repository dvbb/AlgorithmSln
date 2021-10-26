using Algorithm.Hard;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Hard
{
    public class RegularExpressionMatchingTests
    {
        RegularExpressionMatching _member;

        [SetUp]
        public void SetUp()
        {
            _member = new RegularExpressionMatching(); ;
        }

        /// <summary>
        /// 1 <= s.length <= 20
        /// 1 <= p.length <= 30
        /// s contains only lowercase English letters.
        /// p contains only lowercase English letters, '.', and '*'.
        /// It is guaranteed for each appearance of the character '*', there will be a previous valid character to match.
        /// </summary>
        [Test]
        [Ignore("wait for coding")]
        public void IsMatch()
        {
            string s1 = "aa", p1 = "a";
            string s2 = "aa", p2 = "a*";
            string s3 = "ab", p3 = ".*";
            string s4 = "aab", p4 = "c*a*b";
            string s5 = "mississippi", p5 = "mis*is*p*.";
            string s6 = "", p6 = "";
            string s7 = "sjqsafsfsazz", p7 = "sjq.*zz.";
            string s8 = "sjqsafsfsazz", p8 = ".*zz.";
            string s9 = "sjqsafsfsazz", p9 = "sjq.*";
            string s10 = "adfsbxdacfsc", p10 = "a.*b.*c";
            string s11 = "adfsbxbcdacfsc", p11 = "a.*bc.*c";
            Assert.AreEqual(false, _member.IsMatch(s1, p1));
            Assert.AreEqual(true, _member.IsMatch(s2, p2));
            Assert.AreEqual(true, _member.IsMatch(s3, p3));
            Assert.AreEqual(true, _member.IsMatch(s4, p4));
            Assert.AreEqual(false, _member.IsMatch(s5, p5));
            Assert.AreEqual(true, _member.IsMatch(s6, p6));
            Assert.AreEqual(true, _member.IsMatch(s7, p7));
            Assert.AreEqual(true, _member.IsMatch(s8, p8));
            Assert.AreEqual(true, _member.IsMatch(s9, p9));
            Assert.AreEqual(true, _member.IsMatch(s10, p10));
            Assert.AreEqual(true, _member.IsMatch(s11, p11));
        }
    }
}

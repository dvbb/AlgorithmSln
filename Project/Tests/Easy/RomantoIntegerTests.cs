using Algorithm.Easy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Easy
{
    public class RomantoIntegerTests
    {
        private RomantoInteger _member;

        [SetUp]
        public void SetUp()
        {
            _member = new RomantoInteger();
        }

        /// <summary>
        /// 1 <= s.length <= 15
        //  s contains only the characters('I', 'V', 'X', 'L', 'C', 'D', 'M').
        //  It is guaranteed that s is a valid roman numeral in the range[1, 3999].
        /// </summary>
        [Test]
        public void RomanToInt()
        {
            string s1 = "III";
            string s2 = "IV";
            string s3 = "IX";
            string s4 = "LVIII";
            string s5 = "MCMXCIV";
            string s6 = "I";
            string s7 = "MMMCMXCIX";
            Assert.AreEqual(3, _member.RomanToInt(s1));
            Assert.AreEqual(4, _member.RomanToInt(s2));
            Assert.AreEqual(9, _member.RomanToInt(s3));
            Assert.AreEqual(58, _member.RomanToInt(s4));
            Assert.AreEqual(1994, _member.RomanToInt(s5));
            Assert.AreEqual(1, _member.RomanToInt(s6));
            Assert.AreEqual(3999, _member.RomanToInt(s7));
        }
    }
}

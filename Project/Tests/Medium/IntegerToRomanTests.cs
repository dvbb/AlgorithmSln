using Algorithm.Medium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
{
    public class IntegerToRomanTests
    {
        IntegerToRoman _member;
        
        [SetUp]
        public void SetUp()
        {
            _member = new IntegerToRoman();
        }

        /// <summary>
        /// 1 <= num <= 3999
        /// </summary>
        [Test]
        public void IntToRoman()
        {
            int num1 = 3;
            int num2 = 4;
            int num3 = 9;
            int num4 = 58;
            int num5 = 1994;
            int num6 = 1;
            int num7 = 3999;
            string expected1 = "III";
            string expected2 = "IV";
            string expected3 = "IX";
            string expected4 = "LVIII";
            string expected5 = "MCMXCIV";
            string expected6 = "I";
            string expected7 = "MMMCMXCIX";
            Assert.AreEqual(expected1, _member.IntToRoman(num1));
            Assert.AreEqual(expected2, _member.IntToRoman(num2));
            Assert.AreEqual(expected3, _member.IntToRoman(num3));
            Assert.AreEqual(expected4, _member.IntToRoman(num4));
            Assert.AreEqual(expected5, _member.IntToRoman(num5));
            Assert.AreEqual(expected6, _member.IntToRoman(num6));
            Assert.AreEqual(expected7, _member.IntToRoman(num7));
        }
    }
}

using Algorithm.Easy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTests.Easy
{
    internal class AddBinaryTests
    {
        private AddBinary _member;

        [SetUp]
        public void SetUp()
        {
            _member = new AddBinary();
        }

        /// <summary>
        /// 1 <= a.length, b.length <= 104
        /// a and b consist only of '0' or '1' characters.
        /// Each string does not contain leading zeros except for the zero itself.
        /// </summary>
        [Test]
        public void strStr()
        {
            string a1 = "11"; string b1 = "1";
            string expected1 = "100";

            string a2 = "1010"; string b2 = "1011";
            string expected2 = "10101";

            string a3 = "0"; string b3 = "0";
            string expected3 = "0";

            string a4 = "111"; string b4 = "0";
            string expected4 = "111";

            string a5 = "0"; string b5 = "111";
            string expected5 = "111";

            Assert.AreEqual(expected1, _member.AddBinaryMethod(a1, b1));
            Assert.AreEqual(expected2, _member.AddBinaryMethod(a2, b2));
            Assert.AreEqual(expected3, _member.AddBinaryMethod(a3, b3));
            Assert.AreEqual(expected4, _member.AddBinaryMethod(a4, b4));
            Assert.AreEqual(expected5, _member.AddBinaryMethod(a5, b5));
        }
    }
}

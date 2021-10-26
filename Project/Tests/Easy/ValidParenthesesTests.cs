using Algorithm.Eazy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Easy
{
    class ValidParenthesesTests
    {
        private ValidParentheses _member;

        [SetUp]
        public void SetUp()
        {
            _member = new ValidParentheses();
        }

        [Test]
        public void IsValid_ByStack()
        {
            string input1 = "()";
            string input2 = "()[]{}";
            string input3 = "(]";
            string input4 = "([)]";
            string input5 = "{[]}";
            string input6 = "((";
            string input7 = "))";
            string input8 = "";
            Assert.AreEqual(true, _member.IsValid_ByStack(input1));
            Assert.AreEqual(true, _member.IsValid_ByStack(input2));
            Assert.AreEqual(false, _member.IsValid_ByStack(input3));
            Assert.AreEqual(false, _member.IsValid_ByStack(input4));
            Assert.AreEqual(true, _member.IsValid_ByStack(input5));
            Assert.AreEqual(false, _member.IsValid_ByStack(input6));
            Assert.AreEqual(false, _member.IsValid_ByStack(input7));
            Assert.AreEqual(true, _member.IsValid_ByStack(input8));
        }

        [Test]
        public void IsValid_ByStackV2()
        {
            string input1 = "()";
            string input2 = "()[]{}";
            string input3 = "(]";
            string input4 = "([)]";
            string input5 = "{[]}";
            string input6 = "((";
            string input7 = "))";
            string input8 = "";
            Assert.AreEqual(true, _member.IsValid_ByStackV2(input1));
            Assert.AreEqual(true, _member.IsValid_ByStackV2(input2));
            Assert.AreEqual(false, _member.IsValid_ByStackV2(input3));
            Assert.AreEqual(false, _member.IsValid_ByStackV2(input4));
            Assert.AreEqual(true, _member.IsValid_ByStackV2(input5));
            Assert.AreEqual(false, _member.IsValid_ByStackV2(input6));
            Assert.AreEqual(false, _member.IsValid_ByStackV2(input7));
            Assert.AreEqual(true, _member.IsValid_ByStackV2(input8));
        }

        [Test]
        public void IsValid_ByReplace()
        {
            string input1 = "()";
            string input2 = "()[]{}";
            string input3 = "(]";
            string input4 = "([)]";
            string input5 = "{[]}";
            string input6 = "((";
            string input7 = "))";
            string input8 = "";
            Assert.AreEqual(true, _member.IsValid_ByReplace(input1));
            Assert.AreEqual(true, _member.IsValid_ByReplace(input2));
            Assert.AreEqual(false, _member.IsValid_ByReplace(input3));
            Assert.AreEqual(false, _member.IsValid_ByReplace(input4));
            Assert.AreEqual(true, _member.IsValid_ByReplace(input5));
            Assert.AreEqual(false, _member.IsValid_ByReplace(input6));
            Assert.AreEqual(false, _member.IsValid_ByReplace(input7));
            Assert.AreEqual(true, _member.IsValid_ByReplace(input8));
        }
    }
}

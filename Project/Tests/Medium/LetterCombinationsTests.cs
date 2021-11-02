using Algorithm.Medium;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlorithmTests.Medium
{
    public class LetterCombinationsTests
    {
        private LetterCombinations _member;

        [SetUp]
        public void SetUp()
        {
            _member = new LetterCombinations();
        }




        /// <summary>
        /// 0 <= digits.length <= 4
        /// digits[i] is a digit in the range['2', '9'].
        /// </summary>
        [Test]
        public void GetLetterCombinations()
        {
            string digits1 = "23";
            string digits2 = "";
            string digits3 = "2";
            string digits4 = "2289";
            string digits5 = "9";
            string digits6 = "44";
            List<string> expected1 = new List<string>() { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
            List<string> expected2 = new List<string>() { };
            List<string> expected3 = new List<string>() { "a", "b", "c" };
            List<string> expected4 = new List<string>() {"aatw","aatx","aaty","aatz","aauw","aaux","aauy","aauz","aavw","aavx","aavy","aavz","abtw","abtx","abty","abtz","abuw","abux","abuy","abuz","abvw","abvx","abvy","abvz","actw","actx","acty","actz","acuw","acux","acuy","acuz","acvw","acvx","acvy","acvz","batw","batx","baty","batz","bauw","baux","bauy","bauz","bavw","bavx","bavy","bavz","bbtw","bbtx","bbty","bbtz","bbuw","bbux","bbuy","bbuz","bbvw","bbvx","bbvy","bbvz","bctw","bctx","bcty","bctz","bcuw","bcux","bcuy","bcuz","bcvw","bcvx","bcvy","bcvz","catw","catx","caty","catz","cauw","caux","cauy","cauz","cavw","cavx","cavy","cavz","cbtw","cbtx","cbty","cbtz","cbuw","cbux","cbuy","cbuz","cbvw","cbvx","cbvy","cbvz","cctw","cctx","ccty","cctz","ccuw","ccux","ccuy","ccuz","ccvw","ccvx","ccvy","ccvz" };
            List<string> expected5 = new List<string>() { "w", "x", "y", "z" };
            List<string> expected6 = new List<string>() { "gg", "gh", "gi", "hg", "hh", "hi", "ig", "ih", "ii" };
            Assert.AreEqual(expected1, _member.GetLetterCombinations(digits1));
            Assert.AreEqual(expected2, _member.GetLetterCombinations(digits2));
            Assert.AreEqual(expected3, _member.GetLetterCombinations(digits3));
            Assert.AreEqual(expected4, _member.GetLetterCombinations(digits4));Assert.AreEqual(108, _member.GetLetterCombinations(digits4).Count);
            Assert.AreEqual(expected5, _member.GetLetterCombinations(digits5));
            Assert.AreEqual(expected6, _member.GetLetterCombinations(digits6));
        }
    }
}

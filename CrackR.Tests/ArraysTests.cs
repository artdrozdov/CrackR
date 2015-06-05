using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackR.Arrays;

namespace CrackR.Tests
{
    [TestClass]
    public class ArraysTests
    {
        [TestMethod]
        public void DistinctionTest()
        {
            var arr = new char[] { 'a', 'b', 'z', 'x', 'c', 'm', 'n', 'q' };
            Assert.AreEqual(true, arr.IsDistinct());
            arr = new char[] { 'a', 'b', 'z', 'x', 'c', 'm', 'n', 'q', 'b', 'z' };
            Assert.AreEqual(false, arr.IsDistinct());
        }

        [TestMethod]
        public void RelevanceTest()
        {
            var str1 = "abcda";
            var str2 = "dcbaa";
            Assert.AreEqual(true, str1.IsRelevant(str2));
        }

        [TestMethod]
        public void SpaceEscapeTest()
        {
            var str = "Mr John Smith";
            Assert.AreEqual("Mr%20John%20Smith", str.EscapeSpaces());
        }

        [TestMethod]
        public void CompressTest()
        {
            var str = "aabcccccaaa";
            Assert.AreEqual("a2b1c5a3", str.Compress());
        }

        [TestMethod]
        public void TransponentMatrix()
        {
            var m = new int[,] { {0,0,0,0,0}, {0,0,0,0,0}, {0,0,0,0,0}, {0,0,0,0,0}, {1,0,0,0,1} };
            var expected = new int[,] {{1,0,0,0,0}, {0,0,0,0,0}, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 1, 0, 0, 0, 0 } };
            var result = ArrayExtensions.Transponent(m);
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], result[i, j]);
                }
            }
        }
    }
}

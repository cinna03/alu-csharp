using System;
using System.Collections.Generic;
using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            var nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_SingleElement_ReturnsElement()
        {
            var nums = new List<int> { 5 };
            int result = Operations.Max(nums);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Max_MultipleElements_ReturnsMaximum()
        {
            var nums = new List<int> { 3, 7, 2, 9, 1 };
            int result = Operations.Max(nums);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_NegativeNumbers_ReturnsMaximum()
        {
            var nums = new List<int> { -5, -2, -8, -1 };
            int result = Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Max_MixedNumbers_ReturnsMaximum()
        {
            var nums = new List<int> { -3, 0, 5, -1, 2 };
            int result = Operations.Max(nums);
            Assert.AreEqual(5, result);
        }
    }
}
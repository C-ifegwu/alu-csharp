using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            Assert.AreEqual(0, Operations.Max(nums));
        }

        [Test]
        public void Max_NegativeNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -5, -2, -9 };
            Assert.AreEqual(-2, Operations.Max(nums));
        }

        [Test]
        public void Max_PositiveNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { 5, 12, 9 };
            Assert.AreEqual(12, Operations.Max(nums));
        }

        [Test]
        public void Max_MixedNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -5, 12, 0, 9 };
            Assert.AreEqual(12, Operations.Max(nums));
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            Assert.AreEqual(0, Operations.Max(null));
        }
    }
}

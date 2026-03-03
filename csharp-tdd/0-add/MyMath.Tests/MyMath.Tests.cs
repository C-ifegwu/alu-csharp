using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(-5, Operations.Add(-2, -3));
        }

        [Test]
        public void Add_PositiveNumbers_ReturnsCorrectSum()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }

        [Test]
        public void Add_ZeroAndNumber_ReturnsSameNumber()
        {
            Assert.AreEqual(5, Operations.Add(0, 5));
        }
    }
}

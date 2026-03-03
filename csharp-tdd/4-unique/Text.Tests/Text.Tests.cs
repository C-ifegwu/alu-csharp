using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        [Test]
        public void UniqueChar_AllUnique_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("abcdef"));
        }

        [Test]
        public void UniqueChar_SomeDuplicates_ReturnsCorrectIndex()
        {
            Assert.AreEqual(2, Str.UniqueChar("aabcb"));
        }

        [Test]
        public void UniqueChar_NoUnique_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabbcc"));
        }

        [Test]
        public void UniqueChar_SingleCharacter_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("a"));
        }
    }
}

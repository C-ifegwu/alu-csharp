using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void IsPalindrome_SimplePalindrome_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void IsPalindrome_PalindromeWithPunctuation_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("Hello"));
        }

        [Test]
        public void IsPalindrome_Numbers_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("12321"));
        }
    }
}

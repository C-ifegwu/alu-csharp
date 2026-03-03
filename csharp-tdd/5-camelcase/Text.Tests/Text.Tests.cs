using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, Str.CamelCase(""));
        }

        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            Assert.AreEqual(1, Str.CamelCase("hello"));
        }

        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            Assert.AreEqual(3, Str.CamelCase("helloWorldAgain"));
        }

        [Test]
        public void CamelCase_AllUppercaseStartingWords_ReturnsCorrectCount()
        {
            Assert.AreEqual(4, Str.CamelCase("thisIsACamel"));
        }
    }
}

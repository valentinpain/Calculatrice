using NUnit.Framework;

namespace Calculatrice.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Addition_areEqual_integers()
        {
            double expectedResult = 3 + 5;

            Assert.AreEqual(expectedResult, Calculatrice.addition(3, 5));
        }

        [Test]
        public void Addition_areEqual_doubles()
        {
            double expectedResult = 3.6 + 5.8;

            Assert.AreEqual(expectedResult, Calculatrice.addition(3.6, 5.8));
        }
    }
}
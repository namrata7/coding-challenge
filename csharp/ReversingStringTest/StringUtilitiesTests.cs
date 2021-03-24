using CodingChallenge.ReversingString;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReversingStringTest
{
    [TestClass]
    public class StringUtilitiesTests
    {
        [TestMethod]
        public void ReverseReturnsString()
        {
            string input = "some";

            var result = StringUtilities.Reverse(input);

            Assert.IsTrue(!string.IsNullOrEmpty(result), "Returned value empty");
        }

        [TestMethod]
        public void OneWordReverseReturnsReverse()
        {
            string input = "BarBazQux";

            var result = StringUtilities.Reverse(input);

            Assert.IsTrue(result.Equals("xuQzaBraB"), "Returned value is not expected");
        }

        [TestMethod]
        public void MultiWordReverseReturnsReverse2()
        {
            string input = "Hello Foo";

            var result = StringUtilities.Reverse(input);

            Assert.IsTrue(result.Equals("ooF olleH"), "Returned value is not expected");
        }

        [TestMethod]
        public void MultiWordReverseReturnsReverse3()
        {
            string input = "Hello World Foo";

            var result = StringUtilities.Reverse(input);

            Assert.IsTrue(result.Equals("ooF dlroW olleH"), "Returned value is not expected");
        }
    }
}

namespace TestsCMTest
{
    using System.Collections.Generic;

    using CMTest;
    using CMTest.Exceptions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HelpersTest
    {
        [TestMethod]
        public void PositiveDivisorsReturnsEmptyWhenZero()
        {
            var helpers = new Helpers();
            var actual = helpers.PositiveDivisors(0);
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void PositiveDivisorsReturnsEmptyWhenLessThanZero()
        {
            var helpers = new Helpers();
            var actual = helpers.PositiveDivisors(-1);
            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void PositiveDivisorsReturnsOneAndTwoForTwo()
        {
            var helpers = new Helpers();
            var actual = helpers.PositiveDivisors(2);
            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(2, actual[1]);
        }

        [TestMethod]
        public void PositiveDivisorsReturnsCorrectlySupplied()
        {
            var helpers = new Helpers();
            var actual = helpers.PositiveDivisors(42);
            var expected = new List<int> { 1, 2, 3, 6, 7, 14, 21, 42 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PositiveDivisorsReturnsCorrectlySuppliedTwo()
        {
            var helpers = new Helpers();
            var actual = helpers.PositiveDivisors(60);
            var expected = new List<int> { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PositiveDivisorsReturnsCorrectlyPrime()
        {
            var helpers = new Helpers();
            var actual = helpers.PositiveDivisors(71);
            var expected = new List<int> { 1, 71 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTriangleAreaSupplied()
        {
            var helpers = new Helpers();
            var actual = helpers.CalculateTriangleArea(3, 4, 5);
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void CalculateTriangleAreaNegativeExpectExceptionSide1()
        {
            var helpers = new Helpers();
            helpers.CalculateTriangleArea(-1, 4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void CalculateTriangleAreaNegativeExpectExceptionSide2()
        {
            var helpers = new Helpers();
            helpers.CalculateTriangleArea(4, -2, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void CalculateTriangleAreaNegativeExpectExceptionSide3()
        {
            var helpers = new Helpers();
            helpers.CalculateTriangleArea(10, 4, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTriangleException))]
        public void CalculateTriangleAreaSideLengthZero()
        {
            var helpers = new Helpers();
            helpers.CalculateTriangleArea(1, 0, 5);
        }

        [TestMethod]
        public void MostCommonEmptyListExpectEmpty()
        {
            var helpers = new Helpers();
            var actual = helpers.MostCommon(new List<int>());
            CollectionAssert.AreEqual(actual, new List<int>());
        }

        [TestMethod]
        public void MostCommonSingleElementExpectOne()
        {
            var helpers = new Helpers();
            var actual = helpers.MostCommon(new List<int> { 1 });
            CollectionAssert.AreEqual(actual, new List<int> { 1 });
        }

        [TestMethod]
        public void MostCommonSingleElementSample()
        {
            var helpers = new Helpers();
            var actual = helpers.MostCommon(new List<int> { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 });
            CollectionAssert.AreEqual(actual, new List<int> { 5, 4 });
        }

        [TestMethod]
        public void MostCommonSingleElementSampleTwo()
        {
            var helpers = new Helpers();
            var actual = helpers.MostCommon(new List<int> { 1, 2, 3, 4, 5, 1, 6, 7 });
            CollectionAssert.AreEqual(actual, new List<int> { 1 });
        }

        [TestMethod]
        public void MostCommonSingleElementSampleThree()
        {
            var helpers = new Helpers();
            var actual = helpers.MostCommon(new List<int> { 1, 2, 3, 4, 5, 6, 7 });
            CollectionAssert.AreEqual(actual, new List<int> {1, 2, 3, 4, 5, 6, 7});
        }
    }
}

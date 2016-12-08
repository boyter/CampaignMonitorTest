namespace TestsCMTest
{
    using CMTest;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class IsNullOrEmptyTest
    {
        [TestMethod]
        public void NullExpectTrue()
        {
            string testString = null;
            Assert.IsTrue(testString.IsNullOrEmpty());
        }

        [TestMethod]
        public void AExpectFalse()
        {
            Assert.IsFalse("a".IsNullOrEmpty());
        }

        [TestMethod]
        public void EmptyExpectTrue()
        {
            Assert.IsTrue(string.Empty.IsNullOrEmpty());
        }

        [TestMethod]
        public void NullStringExpectFalse()
        {
            Assert.IsFalse("null".IsNullOrEmpty());
        }
    }
}

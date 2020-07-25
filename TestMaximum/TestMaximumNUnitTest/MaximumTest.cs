using NUnit.Framework;

namespace TestMaximumNUnitTest
{
    public class MaximumTest
    {
       

        [Test]
        public void GivenMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility maximum = new TestMaximum.MaximumUtility();
            int maximumNumber = maximum.FindMaximumNumber(4, 3, 1);
            Assert.AreEqual(4, maximumNumber);
        }
        [Test]
        public void GivenMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility maximum = new TestMaximum.MaximumUtility();
            int maximumNumber = maximum.FindMaximumNumber(3, 4, 1);
            Assert.AreEqual(4, maximumNumber);
        }
        [Test]
        public void GivenMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility maximum = new TestMaximum.MaximumUtility();
            float maximumNumber = maximum.FindMaximumNumber(1, 3, 4);
            Assert.AreEqual(4, maximumNumber);
        }

        [Test]
        public void GivenFlotMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility maximum = new TestMaximum.MaximumUtility();
            float maximumNumber = maximum.FindMaximumNumber(4f, 3f, 1f);
            Assert.AreEqual(4f, maximumNumber);
        }
        [Test]
        public void GivenFlotMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility maximum = new TestMaximum.MaximumUtility();
            float maximumNumber = maximum.FindMaximumNumber(3f, 4f, 1f);
            Assert.AreEqual(4f, maximumNumber);
        }
        [Test]
        public void GivenFlotMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility maximum = new TestMaximum.MaximumUtility();
            float maximumNumber = maximum.FindMaximumNumber(1f, 3f, 4f);
            Assert.AreEqual(4f, maximumNumber);
        }
        [Test]
        public void GivenStringMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility maximum = new TestMaximum.MaximumUtility();
            string maximumNumber = maximum.FindMaximumNumber("C","A","B");
            Assert.AreEqual("C", maximumNumber);
        }
        [Test]
        public void GivenStringMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility maximum = new TestMaximum.MaximumUtility();
            string maximumNumber = maximum.FindMaximumNumber<string>("A", "C", "B");
            Assert.AreEqual("C", maximumNumber);
        }
        [Test]
        public void GivenStringMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility maximum = new TestMaximum.MaximumUtility();
            string maximumNumber = maximum.FindMaximumNumber<string>("B", "A", "C");
            Assert.AreEqual("C", maximumNumber);
        }
    }
}
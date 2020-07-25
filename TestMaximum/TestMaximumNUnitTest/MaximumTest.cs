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
            int maximumNumber = maximum.FindMaximumNumber(1, 3, 4);
            Assert.AreEqual(4, maximumNumber);
        }
    }
}
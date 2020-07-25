using NUnit.Framework;

namespace TestMaximumNUnitTest
{
    public class MaximumTest
    {
        [Test]
           public void GivenMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<int> maximum = new TestMaximum.MaximumUtility<int>();
            int maximumNumber = maximum.FindMaximumNumber(1,2,3,50,60,20);
            Assert.AreEqual(60, maximumNumber);
        }
        [Test]
        public void GivenMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<float> maximum = new TestMaximum.MaximumUtility<float>();
            float maximumNumber = maximum.FindMaximumNumber(1f,2f,3f,50f,20f,60f);
            Assert.AreEqual(60f, maximumNumber);
        }
        [Test]
        public void GivenMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<string> maximum = new TestMaximum.MaximumUtility<string>();
            string maximumNumber = maximum.FindMaximumNumber("A","Z","M","N","U");
            Assert.AreEqual("Z", maximumNumber);
        }

        

    }
}
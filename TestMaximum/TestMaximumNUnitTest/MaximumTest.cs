using NUnit.Framework;

namespace TestMaximumNUnitTest
{
    public class MaximumTest
    {


        [Test]
        public void GivenMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<int> maximum = new TestMaximum.MaximumUtility<int>(4, 3, 1);
            int maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(4, maximumNumber);
        }
        [Test]
        public void GivenMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<int> maximum = new TestMaximum.MaximumUtility<int>(3, 4, 1);
            int maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(4, maximumNumber);
        }
        [Test]
        public void GivenMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<float> maximum = new TestMaximum.MaximumUtility<float>(1, 3, 4);
            float maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(4f, maximumNumber);
        }

        [Test]
        public void GivenFlotMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<float> maximum = new TestMaximum.MaximumUtility<float>(4f, 3f, 1f);
            float maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(4f, maximumNumber);
        }
        [Test]
        public void GivenFlotMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<float> maximum = new TestMaximum.MaximumUtility<float>(3f, 4f, 1f);
            float maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(4f, maximumNumber);
        }
        [Test]
        public void GivenFlotMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<float> maximum = new TestMaximum.MaximumUtility<float>(3f, 1f, 4f);
            float maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(4f, maximumNumber);
        }
        [Test]
        public void GivenStringMaximumNumber_WhenAtFirstPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<string> maximum = new TestMaximum.MaximumUtility<string>("C", "A", "B");
            string maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual("C", maximumNumber);
        }
        [Test]
        public void GivenStringMaximumNumber_WhenAtSecondPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<string> maximum = new TestMaximum.MaximumUtility<string>("A","C","B");
            string maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual("C", maximumNumber);
        }
        [Test]
        public void GivenStringMaximumNumber_WhenAtThirdPosition_ReturnTrue()
        {
            TestMaximum.MaximumUtility<string> maximum = new TestMaximum.MaximumUtility<string>("B","C","A");
            string maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual("C", maximumNumber);
        }

    }
}
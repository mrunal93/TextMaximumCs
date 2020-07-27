using NUnit.Framework;

namespace TestMaximumNUnitTest
{
    public class MaximumTest
    {
        [Test]
           public void GivenNumber_WhenTested_ReturnMaximumIntegerNumber()
        {
            TestMaximum.MaximumUtility<int> maximum = new TestMaximum.MaximumUtility<int>(1, 2, 3, 50, 60, 20);
            int maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(60, maximumNumber);
        }
        
        [Test]
        public void GivenNumber_WhenTested_ReturnMaximumFloatNumber()
        {
            TestMaximum.MaximumUtility<float> maximum = new TestMaximum.MaximumUtility<float>(1f, 2f, 3f, 50f, 20f, 60f);
            float maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual(60f, maximumNumber);
        }
      
        [Test]
        public void GivenNumber_WhenTested_ReturnMaximumString()
        {
            TestMaximum.MaximumUtility<string> maximum = new TestMaximum.MaximumUtility<string>("A", "Z", "M", "N", "U");
            string maximumNumber = maximum.FindMaximumNumber();
            Assert.AreEqual("Z", maximumNumber);
        }
    }
}
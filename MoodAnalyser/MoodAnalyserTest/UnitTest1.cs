using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        /// TC 1.1-should return sad mood
        [TestMethod]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            string actual = MoodAnalyser.AnalyseMood("I am in Sad mood");
            Assert.AreEqual(actual, "Sad");
        }

        /// TC 1.2-should return HAPPY mood
        [TestMethod]
        public void GivenAnyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            string actual = MoodAnalyser.AnalyseMood("I am in any mood");
            Assert.AreEqual(actual, "HAPPY");
        }
    }
}
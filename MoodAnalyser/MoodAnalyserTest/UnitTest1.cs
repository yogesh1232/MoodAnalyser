using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        /// Repeat-TC 1.1
        [TestMethod]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(actual, "SAD");
        }

        /// Repeat-TC 1.2
        [TestMethod]
        public void GivenAnyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy mood");
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(actual, "SAD");
        }

        //TC 2.1
        [TestMethod]
        public void GivenNullMood_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser(null);
            string actual = moodAnalyser.AnalyseMood();
            Assert.AreEqual(actual, "happy");
        }
    }
}
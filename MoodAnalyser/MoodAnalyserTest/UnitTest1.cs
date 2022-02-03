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

        //TC-3.1
        [TestMethod]
        public void GivenNullMood_ShouldReturnException()
        {
            string expected = "Mood is null";
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser(null);
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //TC-3.2
        [TestMethod]
        public void GivenEmptyMood_ShouldReturnException()
        {
            string expected = "Mood is empty";
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser("");
                string actual = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //TC-4.1
        [TestMethod]
        public void GivenMoodAnalyserReflection_ShouldReturnObject()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(actual);
        }

        /// TC-4.2 should throw NO_SUCH_CLASS exception.
        [TestMethod]
        public void GivenClassNameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        /// TC-4.2 should throw NO_SUCH_CONTRUCTOR exception.
        [TestMethod]
        public void GivenConstructorNameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}
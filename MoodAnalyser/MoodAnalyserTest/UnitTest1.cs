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

        /// TC-4.2 should throw NO_SUCH_CONSTRUCTOR exception.
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

        /// TC-5.1 Returns the mood analyser object with parameterized constructor.
        [TestMethod]
        public void GivenMoodAnalyserParameterizedConstructor_ShouldReturnObject()
        {
            object expected = new MoodAnalyser("I am Parameter constructor");
            object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "I am Parameter constructor");
            expected.Equals(actual);
        }

        /// TC-5.2 should throw NO_SUCH_CLASS exception with parameterized constructor.
        [TestMethod]
        public void GivenClassNameImproperParameterizedConstructor_ShouldReturnMoodAnalysisException()
        {
            string expected = "Class not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedConstructor("MoodAnalyser.MoodAnalyser", "MoodAnalyser", "I am Parameter constructor");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        /// TC-5.3 should throw NO_SUCH_CONSTRUCTOR exception with parameterized constructor.
        [TestMethod]
        public void GivenImproperParameterizedConstructorName_ShouldReturnMoodAnalysisException()
        {
            string expected = "Constructor not found";
            try
            {
                object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "I am Parameter constructor");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        /// UC5-Refactor dry principle
        [TestMethod]
        public void GivenMoodAnalyserOptionalVarible_ShouldReturnObject()
        {
            object expected = new MoodAnalyser("I am Parameter constructor");
            object actual = MoodAnalyserFactory.CreateMoodAnalyserOptionalVariable("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "I am Parameter constructor");
            expected.Equals(actual);
        }

        /// TC-6.1 Invokes the method using reflection and should return happy
        [TestMethod]
        public void InvokeMethodReflection_ShouldRetunHappy()
        {
            string expected = "happy";
            string actual = MoodAnalyserFactory.InvokeAnalyseMood("I am happy", "AnalyseMood");
            expected.Equals(actual);
        }

        /// TC-6.2  should throw method not found exception.
        [TestMethod]
        public void GivenMethodnameImproper_ShouldReturnMoodAnalysisException()
        {
            string expected = "No method found";
            try
            {
                string actual = MoodAnalyserFactory.InvokeAnalyseMood("I am happy", "MoodAnalyse");
                expected.Equals(actual);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// TC-7.1-Change mood dynamically.
        [TestMethod]
        public void GivenSetMoodDynamically_ShouldReturnHappy()
        {
            string expected = "Happy";
            string actual = MoodAnalyserFactory.SetFieldDynamic("Happy", "message");
            expected.Equals(actual);
        }
    
        /// TC-7.2 Given field name improper should return exception
        [TestMethod]
        public void GivenFieldNameImproper_ShouldReturnMoodAnaysisException()
        {
            string expected = "Field not found";
            try
            {
                string actual = MoodAnalyserFactory.SetFieldDynamic("Happy", "msg");
                expected.Equals(actual);
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        /// TC-7.3 Change message dynamically
        [TestMethod]
        public void ChangeMeassageDynamically_ShouldReturnMessage()
        {
            string expected = "Message should not be null";
            try
            {
                string actual = MoodAnalyserFactory.SetFieldDynamic(null, "message");
                expected.Equals(actual);
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}
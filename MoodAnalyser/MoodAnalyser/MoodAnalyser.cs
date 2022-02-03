using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string message;

        /// default contructor
        public MoodAnalyser()
        {
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// analyse the mood
        /// <param name="message"></param>
        /// <returns>happy or sad mood </returns>
        public string AnalyseMood()
        {
            try
            {
                message = message.ToLower();
                if (message == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MOOD, "Mood is null");
                }
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MOOD, "Mood is empty");
                }
                if (message.Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
    
}

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
                if (message.Contains("Happy"))
                    return "happy";
                else
                    return "SAD";
            }
            catch (NullReferenceException e)
            {
                return "happy";
            }
        }
    }
    
}

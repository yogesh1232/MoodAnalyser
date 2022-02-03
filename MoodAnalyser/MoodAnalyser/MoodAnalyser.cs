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
        /// <summary>
        /// anayse the mood
        /// </summary>
        /// <param name="message"></param>
        /// <returns>happy or sad mood </returns>
        public string AnalyseMood()
        {
            message = message.ToLower();
            if (message.Contains("Happy"))
                return "HAPPY";
            else
                return "SAD";
        }
    }
    
}

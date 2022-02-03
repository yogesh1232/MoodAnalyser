using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyserException : Exception
    {
        private readonly ExceptionType type;
        public enum ExceptionType
        {
            NULL_MOOD, EMPTY_MOOD
        }
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay12
{
    public class MoodAnalyserCustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            NO_SUCH_CLASS,
            NO_SUCH_METHOD,
            EMPTY_MESSAGE,
            NULL_MESSAGE,
        }

        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
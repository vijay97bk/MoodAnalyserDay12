using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay11
{
    /// <summary>
    /// UC3 Custom exceptions
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MoodAnalyserCustomException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
        }
        public ExceptionType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyserCustomException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public MoodAnalyserCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

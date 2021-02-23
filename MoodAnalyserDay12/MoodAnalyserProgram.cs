using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay11
{
    public class AnalyseMood
    {
        string message;
        public AnalyseMood(string message)
        {
            this.message = message;
        }
        public string MoodAnalyse()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.EMPTY_MESSAGE, "mood Cannot be empty");
                if (this.message.Contains("HAPPY"))
                    return "HAPPY";
                else
                    return "SAD";

            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NULL_MESSAGE, "mood Cannot be null");
            }


        }


    }
}

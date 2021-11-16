using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay20
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {

        }
        public MoodAnalyser(string msg)
        {
            message = msg;
        }

        public string AnalyseMood()
        {
            try
            {/*
              //  if (message.Equals(string.Empty))
                {
                    throw new CustomMoodAnalyser(CustomMoodAnalyser.ExceptionType.Entered_Empty_String, "String is Empty");
                }*/

                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomMoodAnalyser(CustomMoodAnalyser.ExceptionType.Entered_null, "Nothing is entered");
            }
        }

    }
}


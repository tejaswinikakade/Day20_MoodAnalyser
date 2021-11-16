using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay20
{
    public class CustomMoodAnalyser : Exception
    {
        public enum ExceptionType
        {
            Entered_null,
            Entered_Empty_String,
            No_Such_Class,
            No_Such_Method,
            No_Such_Field
        }

        ExceptionType enumtype;

        public CustomMoodAnalyser(ExceptionType type, string msg) : base(msg)
        {
            enumtype = type;
        }
    }
}
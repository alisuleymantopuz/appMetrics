using System;

namespace appMetrics.Exceptions
{
    public class PostException : Exception
    {
        public override string Message
        {
            get
            {
                return "PostException";
            }
        }
    }
}
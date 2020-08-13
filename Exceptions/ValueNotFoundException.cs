using System;

namespace appMetrics.Exceptions
{
    public class ValueNotFoundException : Exception
    {
        public override string Message
        {
            get
            {
                return "ValueNotFoundException";
            }
        }
    }
}
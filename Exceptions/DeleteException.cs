using System;

namespace appMetrics.Exceptions
{
    public class DeleteException : Exception
    {

        public override string Message
        {
            get
            {
                return "DeleteException";
            }
        }

    }
}
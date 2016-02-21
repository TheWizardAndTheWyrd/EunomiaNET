using System;

namespace Eunomia.NET.Exceptions
{
    public class RuleExecutionException : Exception
    {
        public RuleExecutionException()
        {
            
        }

        public RuleExecutionException(string message)
            : base(message)
        {
            
        }

        public RuleExecutionException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
using System;

namespace Eunomia.NET.Exceptions.Admin
{
    public class RuleExecutionSetDeregistrationException : Exception
    {
        public RuleExecutionSetDeregistrationException()
        {
            
        }

        public RuleExecutionSetDeregistrationException(string message)
            :base(message)
        {
            
        }

        public RuleExecutionSetDeregistrationException(string message, Exception inner)
            :base(message, inner)
        {
            
        }
    }
}
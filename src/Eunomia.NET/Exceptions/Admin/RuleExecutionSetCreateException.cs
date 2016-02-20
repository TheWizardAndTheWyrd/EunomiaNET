using System;

namespace Eunomia.NET.Exceptions.Admin
{
    public class RuleExecutionSetCreateException : Exception
    {
        public RuleExecutionSetCreateException()
        {
            
        }

        public RuleExecutionSetCreateException(string message)
            : base(message)
        {
            
        }

        public RuleExecutionSetCreateException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
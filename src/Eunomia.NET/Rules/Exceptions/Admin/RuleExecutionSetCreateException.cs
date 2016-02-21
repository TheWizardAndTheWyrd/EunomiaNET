using System;

namespace Eunomia.NET.Rules.Exceptions.Admin
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
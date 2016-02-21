using System;

namespace Eunomia.NET.Exceptions
{
    public class RuleExecutionSetNotFoundException : Exception
    {
        public RuleExecutionSetNotFoundException()
        {
            
        }

        public RuleExecutionSetNotFoundException(string message)
            : base(message)
        {
            
        }

        public RuleExecutionSetNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
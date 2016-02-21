using System;

namespace Eunomia.NET.Rules.Exceptions.Admin
{
    public class RuleExecutionSetRegisterException : Exception
    {
        public RuleExecutionSetRegisterException()
        {
            
        }

        public RuleExecutionSetRegisterException(string message)
            : base(message)
        {
            
        }

        public RuleExecutionSetRegisterException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
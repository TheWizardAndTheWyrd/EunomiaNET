using System;

namespace Eunomia.NET.Rules.Exceptions
{
    public class RuleSessionTypeUnsupportedException : Exception
    {
        public RuleSessionTypeUnsupportedException()
        {
            
        }

        public RuleSessionTypeUnsupportedException(string message)
            : base(message)
        {
            
        }

        public RuleSessionTypeUnsupportedException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
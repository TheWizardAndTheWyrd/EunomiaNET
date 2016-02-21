using System;

namespace Eunomia.NET.Rules.Exceptions
{
    public class RuleSessionCreateException : Exception
    {
        public RuleSessionCreateException()
        {
            
        }

        public RuleSessionCreateException(string message)
            : base(message)
        {
            
        }

        public RuleSessionCreateException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
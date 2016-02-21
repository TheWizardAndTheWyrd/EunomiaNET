using System;

namespace Eunomia.NET.Exceptions
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
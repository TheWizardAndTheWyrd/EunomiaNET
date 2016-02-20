using System;

namespace Eunomia.NET.Exceptions.Admin
{
    public class RuleAdministrationException : Exception
    {
        public RuleAdministrationException()
        {
            
        }

        public RuleAdministrationException(string message)
            :base(message)
        {
            
        }

        public RuleAdministrationException(string message, Exception inner)
            :base(message, inner)
        {
            
        }
    }
}
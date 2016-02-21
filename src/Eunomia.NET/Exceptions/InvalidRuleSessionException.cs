﻿using System;

namespace Eunomia.NET.Exceptions
{
    public class InvalidRuleSessionException : Exception
    {
        public InvalidRuleSessionException()
        {
            
        }

        public InvalidRuleSessionException(string message)
            : base(message)
        {
            
        }

        public InvalidRuleSessionException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
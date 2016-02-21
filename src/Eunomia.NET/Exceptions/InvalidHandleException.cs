﻿using System;

namespace Eunomia.NET.Exceptions
{
    public class InvalidHandleException : Exception
    {
        public InvalidHandleException()
        {
            
        }

        public InvalidHandleException(string message)
            : base(message)
        {
            
        }

        public InvalidHandleException(string message, Exception inner)
            : base(message, inner)
        {
            
        }
    }
}
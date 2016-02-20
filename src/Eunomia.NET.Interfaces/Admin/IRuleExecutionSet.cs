using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Eunomia.NET.Interfaces.Admin
{
    public interface IRuleExecutionSet
    {
        string Name { get; set; }

        string Description { get; set; }

        object Property { get; set; }

        string DefaultObjectFilter { get; set; }

        IEnumerable<object> Rules { get; }
    }
}
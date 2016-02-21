using System.Collections.Generic;

namespace Eunomia.NET.Interfaces.Rules.Admin
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
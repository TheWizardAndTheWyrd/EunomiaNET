using System.Collections.Generic;
using System.Xml;

namespace Eunomia.NET.Interfaces.Rules.Admin
{
    public interface ILocalRuleExecutionSetProvider
    {
        IRuleExecutionSet CreateRuleExecutionSet(System.IO.StreamReader inputStream, IDictionary<object, object> props);

        IRuleExecutionSet CreateRuleExecutionSet(System.IO.Stream stream, IDictionary<object, object> props);

        IRuleExecutionSet CreateRuleExecutionSet(object input, IDictionary<object, object> props);
    }
}
using System.Collections.Generic;

namespace Eunomia.NET.Interfaces.Admin
{
    public interface ILocalRuleExecutionSetProvider
    {
        IRuleExecutionSet CreateRuleExecutionSet(System.IO.StreamReader inputStream, IDictionary<object, object> collection);

        IRuleExecutionSet CreateRuleExecutionSet(System.IO.Stream stream, IDictionary<object, object> collection);

        IRuleExecutionSet CreatRuleExecutionSet(object input, IDictionary<object, object> collection);
    }
}
using System.Collections.Generic;

namespace Eunomia.NET.Interfaces
{
    public interface IStatelessRuleSession : IRuleSession
    {
        IEnumerable<object> ExecuteRules(IEnumerable<object> input);

        IEnumerable<object> ExecuteRules(IEnumerable<object> input, IObjectFilter filter);
    }
}
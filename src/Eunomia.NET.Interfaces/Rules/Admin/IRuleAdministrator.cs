using System.Collections.Generic;

namespace Eunomia.NET.Interfaces.Rules.Admin
{
    public interface IRuleAdministrator
    {
        IRuleExecutionSetProvider RuleExecutionSetProvider { get; }
        
        ILocalRuleExecutionSetProvider LocalRuleExecutionSetProvider { get; }

        void RegisterRuleExecutionSet(string name, IRuleExecutionSet ruleExecutionSet, IDictionary<object, object> collection);

        void DeregisterRuleExecutionSet(string name, IDictionary<object, object> collection);
    }
}
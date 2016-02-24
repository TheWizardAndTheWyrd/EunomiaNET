using System.Collections.Generic;
using Eunomia.NET.Interfaces.Rules.Admin;

namespace Eunomia.NET.Rules.Admin
{
    public class RuleAdministrator : IRuleAdministrator
    {
        public IRuleExecutionSetProvider RuleExecutionSetProvider { get; }
        public ILocalRuleExecutionSetProvider LocalRuleExecutionSetProvider { get; }

        public void RegisterRuleExecutionSet(string name, IRuleExecutionSet ruleExecutionSet, IDictionary<object, object> collection)
        {
            throw new System.NotImplementedException();
        }

        public void DeregisterRuleExecutionSet(string name, IDictionary<object, object> collection)
        {
            throw new System.NotImplementedException();
        }
    }
}
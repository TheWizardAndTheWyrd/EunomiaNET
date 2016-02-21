using Eunomia.NET.Interfaces.Rules.Enums;

namespace Eunomia.NET.Interfaces.Rules
{
    public interface IRuleSession
    {
        IRuleExecutionSetMetadata RuleExecutionSetMetadata { get; }

        void Release();

        SessionTypeEnum SessionType { get; }
    }
}
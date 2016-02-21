using Eunomia.NET.Interfaces.Enums;

namespace Eunomia.NET.Interfaces
{
    public interface IRuleSession
    {
        IRuleExecutionSetMetadata RuleExecutionSetMetadata { get; }

        void Release();

        SessionTypeEnum SessionType { get; }
    }
}
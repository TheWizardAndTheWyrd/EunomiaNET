using System.Collections.Generic;
using Eunomia.NET.Interfaces.Enums;

namespace Eunomia.NET.Interfaces
{
    public interface IRuleRuntime
    {
        IRuleSession CreateRuleSession(string name, IDictionary<object, object> collection, SessionTypeEnum sessionType);
    }
}
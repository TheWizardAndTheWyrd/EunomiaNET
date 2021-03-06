﻿using System.Collections.Generic;
using Eunomia.NET.Interfaces.Rules.Enums;

namespace Eunomia.NET.Interfaces.Rules
{
    public interface IRuleRuntime
    {
        IRuleSession CreateRuleSession(string name, IDictionary<object, object> collection, SessionTypeEnum sessionType);
    }
}
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Eunomia.NET.Interfaces.Admin
{
    public interface IRuleExecutionSetProvider
    {
        IRuleExecutionSet CreateRuleExecutionSet(XmlElement element, IDictionary<object, object> collection);

        IRuleExecutionSet CreateRuleExecutionSet(IXmlSerializable input, IDictionary<object, object> collection);

        IRuleExecutionSet CreateRuleExecutionSet(string name, IDictionary<object, object> collection);
    }
}
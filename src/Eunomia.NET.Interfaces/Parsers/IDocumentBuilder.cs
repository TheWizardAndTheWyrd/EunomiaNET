using System.Xml;

namespace Eunomia.NET.Interfaces.Parsers
{
    public interface IDocumentBuilder
    {
        IDocumentBuilder NewInstance();
        XmlDocument Parse(IInputSource inputSource);
    }
}
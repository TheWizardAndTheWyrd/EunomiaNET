using System.Xml;
using Eunomia.NET.Interfaces.Parsers;

namespace Eunomia.NET.Parsers
{
    public class DocumentBuilder : IDocumentBuilder
    {
        public static IDocumentBuilder NewInstance()
        {
            return new DocumentBuilder();
        }

        public XmlDocument Parse(IInputSource inputSource)
        {
            throw new System.NotImplementedException();
        }

        IDocumentBuilder IDocumentBuilder.NewInstance()
        {
            return NewInstance();
        }
    }
}
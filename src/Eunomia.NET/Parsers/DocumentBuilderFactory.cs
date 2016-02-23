using Eunomia.NET.Interfaces.Parsers;

namespace Eunomia.NET.Parsers
{
    public class DocumentBuilderFactory : IDocumentBuilderFactory
    {
        public static IDocumentBuilderFactory NewInstance()
        {
            return new DocumentBuilderFactory();
        }

        IDocumentBuilderFactory IDocumentBuilderFactory.NewInstance()
        {
            return NewInstance();
        }
    }
}
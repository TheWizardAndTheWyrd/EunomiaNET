using System.IO;
using Eunomia.NET.Interfaces;

namespace Eunomia.NET
{
    public class Engine : IEngine
    {
        public bool Parse { get; set; }

        public Engine(StringReader reader, IEngine engine)
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}
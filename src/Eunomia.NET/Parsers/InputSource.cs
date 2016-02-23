using System.IO;
using System.Xml;
using Eunomia.NET.Interfaces.Parsers;

namespace Eunomia.NET.Parsers
{
    /// <summary>
    /// TODO: Make generic to keep code DRY and SOLID.
    /// </summary>
    public class InputSource : IInputSource
    {
        private Stream _stream;
        private StreamReader _inputStream;
        //private XmlElement _xmlElement;

        public InputSource(Stream stream)
        {
            this._stream = stream;
        }

        public InputSource(StreamReader inputStream)
        {
            this._inputStream = inputStream;
        }

        //public InputSource(XmlElement inputElement)
        //{
        //    this._xmlElement = inputElement;
        //}
    }
}
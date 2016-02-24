using Eunomia.NET.Interfaces.Rules;

namespace Eunomia.NET.Rules
{
    /// <summary>
    /// I'm not sure why this class is useful.  Is it used as a base class?
    /// It appears to only pass an object through the Filter method.
    /// </summary>
    public class ObjectFilter : IObjectFilter
    {
        public object Filter(object filter)
        {
            return filter;
        }

        public void Reset()
        {
        }
    }
}
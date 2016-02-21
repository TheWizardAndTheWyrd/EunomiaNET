namespace Eunomia.NET.Interfaces.Rules
{
    public interface IObjectFilter
    {
        object Filter(object filter);

        void Reset();
    }
}
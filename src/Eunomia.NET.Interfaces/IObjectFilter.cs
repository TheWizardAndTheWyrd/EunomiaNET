namespace Eunomia.NET.Interfaces
{
    public interface IObjectFilter
    {
        object Filter(object filter);

        void Reset();
    }
}
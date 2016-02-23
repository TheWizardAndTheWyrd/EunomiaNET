namespace Eunomia.NET.Interfaces
{
    public interface IEngine
    {
        bool Parse { get; set; }
        void Reset();
    }
}
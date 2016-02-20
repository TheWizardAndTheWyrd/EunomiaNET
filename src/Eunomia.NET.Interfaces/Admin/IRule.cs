namespace Eunomia.NET.Interfaces.Admin
{
    public interface IRule
    {
        string Name { get; }
        
        string Description { get; }
        
        object Property { get; set; }
    }
}
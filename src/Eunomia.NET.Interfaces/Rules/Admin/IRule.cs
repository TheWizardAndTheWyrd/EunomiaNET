namespace Eunomia.NET.Interfaces.Rules.Admin
{
    public interface IRule
    {
        string Name { get; }
        
        string Description { get; }
        
        object Property { get; set; }
    }
}
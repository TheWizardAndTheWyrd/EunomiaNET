namespace Eunomia.NET.Interfaces.Rules
{
    public interface IRuleExecutionSetMetadata
    {
        string Uri { get; }

        string Name { get; }

        string Description { get; }
    }
}
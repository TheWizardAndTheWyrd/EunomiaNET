using System.Collections.Generic;

namespace Eunomia.NET.Interfaces.Rules
{
    public interface IStatefulRuleSession : IRuleSession
    {
        IEnumerable<object> Objects { get; set; }

        IEnumerable<IHandle> Handles { get; set; }

        bool ContainsObject(IHandle handle);

        IHandle AddObject(object obj);

        IEnumerable<object> AddObjects(IEnumerable<object> objects);

        void UpdateObject(IHandle handle, object obj);

        void RemoveObject(IHandle handle);

        object GetObject(IHandle handle);

        IEnumerable<object> GetObjects(IObjectFilter filter);

        void ExecuteRules();

        void Reset();
    }
}
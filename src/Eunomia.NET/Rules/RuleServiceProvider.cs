using Eunomia.NET.Util;
using Eunomia.NET.Interfaces.Rules;
using Eunomia.NET.Interfaces.Rules.Admin;

namespace Eunomia.NET.Rules
{
    public abstract class RuleServiceProvider<T>
    {
        ClassLoader<T> ClassLoader { get; set; }

        IRuleRuntime RuleRuntime { get; set; }

        IRuleAdministrator RuleAdministrator { get; set; }

        public virtual T CreateInstance(string assemblyName)
        {
            if (this.ClassLoader == null)
            {
                this.ClassLoader = new ClassLoader<T>(assemblyName);
            }

            return this.ClassLoader.Activate();
        }
    }
}
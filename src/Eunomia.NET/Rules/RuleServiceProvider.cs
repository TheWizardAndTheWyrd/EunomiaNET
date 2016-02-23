using Eunomia.NET.Util;
using Eunomia.NET.Interfaces.Rules;
using Eunomia.NET.Interfaces.Rules.Admin;

namespace Eunomia.NET.Rules
{
    public class RuleServiceProvider<T>
    {
        public ClassLoader<T> ClassLoader { get; set; }

        public IRuleRuntime RuleRuntime { get; set; }

        public IRuleAdministrator RuleAdministrator { get; set; }

        //public virtual T CreateInstance(string assemblyName)
        //{
        //    if (this.ClassLoader == null)
        //    {
        //        this.ClassLoader = new ClassLoader<T>(assemblyName);
        //    }

        //    return this.ClassLoader.Activate();
        //}
    }

    public static class RuleServiceProviderExtensions
    {
        public static T CreateInstance<T>(this RuleServiceProvider<T> ruleServiceProvider, string assemblyName)
        {
            if (ruleServiceProvider.ClassLoader == null)
            {
                ruleServiceProvider.ClassLoader = new ClassLoader<T>(assemblyName);
            }

            return ruleServiceProvider.ClassLoader.Activate();
        }
    }
}
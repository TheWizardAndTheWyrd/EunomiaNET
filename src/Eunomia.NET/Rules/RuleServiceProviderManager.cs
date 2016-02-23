using System;
using System.Collections.Generic;
using Eunomia.NET.Rules.Exceptions;
using Eunomia.NET.Util;

namespace Eunomia.NET.Rules
{
    public abstract class RuleServiceProviderManager<T>
    {
        public virtual IDictionary<object, object> RegistrationMap { get; private set; }

        public virtual void RegisterRuleServiceProvider(string uri, string assemblyName)
        {
            try
            {
                if (this.RegistrationMap == null)
                    RegistrationMap = new Dictionary<object, object>();

                var ruleServiceProvider =
                    new RuleServiceProvider<T> {ClassLoader = new ClassLoader<T>(assemblyName)}.CreateInstance(
                        assemblyName);

                RegistrationMap.Add(new KeyValuePair<object, object>(uri, ruleServiceProvider));
            }
            catch (Exception e)
            {
                throw new ConfigurationException($"Could not register driver: {assemblyName} against URI: {uri}", e);
            }
        }
    }
}
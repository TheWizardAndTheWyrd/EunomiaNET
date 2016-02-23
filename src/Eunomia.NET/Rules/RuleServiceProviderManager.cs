using System;
using System.Collections.Generic;
using Eunomia.NET.Rules.Exceptions;
using Eunomia.NET.Util;

namespace Eunomia.NET.Rules
{
    public abstract class RuleServiceProviderManager<T>
    {
        public virtual IDictionary<Uri, object> RegistrationMap { get; private set; }

        public virtual void RegisterRuleServiceProvider(string uri, string assemblyName)
        {
            try
            {
                if (this.RegistrationMap == null)
                    RegistrationMap = new Dictionary<Uri, object>();

                // TODO: Should we store the Type along with the created instance; say, in a Tuple?  This would be used for casting from object to the stored type in the dictionary value.
                var ruleServiceProvider =
                    new RuleServiceProvider<T> {ClassLoader = new ClassLoader<T>(assemblyName)}.CreateInstance(
                        assemblyName);

                RegistrationMap.Add(new KeyValuePair<Uri, object>(new Uri(uri), ruleServiceProvider));
            }
            catch (Exception e)
            {
                throw new ConfigurationException($"Could not register driver: {assemblyName} against URI: {uri}", e);
            }
        }
    }
}
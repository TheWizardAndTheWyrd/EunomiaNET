using System;
using System.Reflection;

namespace Eunomia.NET.Util
{
    public class ClassLoader<T>
    {
        public object ActivatedObject { get; private set; }

        public string AssemblyName { get; private set; }

        public Type ActivatedType { get; private set; }

        public ClassLoader(string assemblyName)
        {
            AssemblyName = assemblyName;
        }

        public T Activate()
        {
            Assembly assembly;

            try
            {
                assembly = Assembly.LoadFrom(AssemblyName);
            }
            catch (Exception e)
            {
                throw new Exception($"Can't find Assembly: {AssemblyName}", e);
            }

            try
            {
                ActivatedType = assembly.GetType(typeof (T).ToString());
            }
            catch (Exception e)
            {
                throw new Exception($"Can't get ActivatedType: {typeof(T)}", e);
            }

            try
            {
                ActivatedObject = Activator.CreateInstance(ActivatedType);
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to activate object of Type: {ActivatedType}", e);
            }

            return (T) ActivatedObject;
        }
    }
}
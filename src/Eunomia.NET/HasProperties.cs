using System;
using System.Collections.Generic;

namespace Eunomia.NET
{
    /// <summary>
    /// TODO: Determine if this class is even necessary.  It just gets and sets keys and values in IDictionary.
    /// </summary>
    public abstract class HasProperties
    {
        private IDictionary<object, object> _map;

        protected HasProperties()
        {
            this._map = new Dictionary<object, object>();
        }

        public virtual object GetProperty(object key)
        {
            try
            {
                return this._map[key];
            }
            catch (Exception e)
            {
                throw new Exception($"Error access Property: {key}.", e);
            }
        }

        public virtual void SetProperty(object key, object value)
        {
            try
            {
                this._map.Add(new KeyValuePair<object, object>(key, value));
            }
            catch (Exception e)
            {
                throw new Exception($"Unable to add Key: {key} and Value: {value}.", e);
            }
        }
    }
}
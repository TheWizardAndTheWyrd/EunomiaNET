using System;
using Eunomia.NET.Interfaces;
using Eunomia.NET.Interfaces.Rules;

namespace Eunomia.NET.Rules
{
    [Serializable]
    public class Handle : IHandle
    {
        private object _mObject;
        private IFact _mFact;

        public object MObject
        {
            get { return _mObject; }
            private set { _mObject = value; }
        }

        public IFact MFact
        {
            get { return _mFact; }
            private set { _mFact = value; }
        }

        public Handle(IFact fact, object obj)
        {
            this._mFact = fact;
            this._mObject = obj;
        }

        // TODO: Work on this and the complimentary != operator.
        //public static bool operator == (Handle leftObject, IHandle rightObject)
        //{
        //    return ((Handle) leftObject == (rightObject as Handle));
        //}

        /// <summary>
        /// This Equals method overrides the virtual method in the System.Object class.
        /// 
        /// There are two conditions whose truthiness must be evaluated:
        /// 
        /// 1.  Is the parameter object o an instance of the Type of MObject?
        /// 
        /// 2.  Is this.MObject == o.Object after casting o to <see cref="Handle"/>?
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public new bool Equals(object o)
        {
            return (o.GetType().IsInstanceOfType(this.MObject)) && (this.MObject == ((Handle) o).MObject);
        }

        public int HashCode()
        {
            return this.GetHashCode();
        }
    }
}
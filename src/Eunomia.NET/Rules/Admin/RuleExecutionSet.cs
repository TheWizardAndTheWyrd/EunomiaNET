using System;
using System.Collections.Generic;
using Eunomia.NET.Interfaces;
using Eunomia.NET.Interfaces.Rules.Admin;

namespace Eunomia.NET.Rules.Admin
{
    public class RuleExecutionSet : IRuleExecutionSet
    {
        private IRete _mRete;
        private string _mName;
        private string _mDescription;
        private Uri _mUri;
        private string _mFilter;

        public RuleExecutionSet(string name, string description, string uri)
        {
            this._mRete = new Rete();
            this._mName = name;
            this._mDescription = description;
            this._mUri = new Uri(uri);
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public object Property { get; set; }
        public string DefaultObjectFilter { get; set; }
        public IEnumerable<object> Rules { get; }
        public IEngine Engine { get; }
    }
}
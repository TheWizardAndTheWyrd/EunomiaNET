using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Eunomia.NET.Interfaces;
using Eunomia.NET.Interfaces.Parsers;
using Eunomia.NET.Interfaces.Rules.Admin;
using Eunomia.NET.Parsers;
using Eunomia.NET.Rules.Exceptions.Admin;

namespace Eunomia.NET.Rules.Admin
{
    public class LocalRuleExecutionSetProvider : ILocalRuleExecutionSetProvider
    {
        public static string Name = "name";
        public static string Description = "description";

        /// <summary>
        /// TODO: Extract method logic into generic method to keep the code DRY.
        /// </summary>
        /// <param name="inputStream"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        public IRuleExecutionSet CreateRuleExecutionSet(StreamReader inputStream, IDictionary<object, object> props)
        {
            XmlDocument doc = null;

            try
            {
                IDocumentBuilderFactory dbf = DocumentBuilderFactory.NewInstance();
                IDocumentBuilder db = DocumentBuilder.NewInstance();

                doc = db.Parse(new InputSource(inputStream));
            }
            catch (Exception e)
            {
                throw new RuleExecutionSetCreateException("Parse error.", e);
            }

            return this.CreateRuleExecutionSet(doc.DocumentElement, props);
        }

        /// <summary>
        /// TODO: Extract method logic into generic method to keep the code DRY.
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        public IRuleExecutionSet CreateRuleExecutionSet(Stream stream, IDictionary<object, object> props)
        {
            XmlDocument doc = null;

            try
            {
                IDocumentBuilderFactory dbf = DocumentBuilderFactory.NewInstance();
                IDocumentBuilder db = DocumentBuilder.NewInstance();

                doc = db.Parse(new InputSource(stream));
            }
            catch (Exception e)
            {
                throw new RuleExecutionSetCreateException("Parse error.", e);
            }

            return this.CreateRuleExecutionSet(doc.DocumentElement, props);
        }

        public IRuleExecutionSet CreateRuleExecutionSet(object input, IDictionary<object, object> props)
        {
            throw new RuleExecutionSetCreateException("AST not supported.");
        }

        /// <summary>
        /// TODO: This method is in need of heavy refactoring to reduce code duplication.
        /// This was copied almost verbatim from the reference implementation.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        public IRuleExecutionSet CreateRuleExecutionSet(XmlElement input, IDictionary<object, object> props)
        {
            XmlNodeList contents = input.GetElementsByTagName("name");

            if (contents.Count == 0)
            {
                throw new RuleExecutionSetCreateException("Name not specified");
            }

            string name = contents.Item(0)?.FirstChild.Value.Trim();

            contents = input.GetElementsByTagName("description");

            if (contents.Count == 0)
            {
                throw new RuleExecutionSetCreateException("Description not specified");
            }

            string description = contents.Item(0)?.FirstChild.Value.Trim();

            contents = input.GetElementsByTagName("code");

            if (contents.Count == 0)
            {
                throw new RuleExecutionSetCreateException("Description not specified");
            }

            string code = contents.Item(0)?.FirstChild.Value;

            // TODO: Remove this!  This is leaky.  This method shouldn't be instantiating one of its parameters!
            //if (props == null)
            //{
            //    props = new Dictionary<object, object>();
            //}

            props["name"] = name;
            props["description"] = description;

            StringReader reader = new StringReader(code);

            try
            {
                return this.CreateRuleExecutionSetFromCLP(reader, props);
            }
            catch (Exception e)
            {
                throw new RuleExecutionSetCreateException(e.Message);
            }
        }

        private IRuleExecutionSet CreateRuleExecutionSetFromCLP(StringReader reader, IDictionary<object, object> props)
        {
            try
            {
                string name = "Untitled";
                string description = "Generic rule execution set";
                
                // TODO: Remove default value of null!  This is the "billion dollar mistake" at work.
                IRuleExecutionSet rs = null;

                // TODO: props should never be null!
                if (props != null)
                {
                    if (props.ContainsKey("name"))
                    {
                        name = props["name"] as string;
                    }

                    if (props.ContainsKey("description"))
                    {
                        description = props["description"] as string;
                    }

                    rs = new RuleExecutionSet(name, description, null);
                    IEngine engine = new Engine(reader, rs.Engine);
                    engine.Parse = false;
                    rs.Engine.Reset();

                    
                }
                return (RuleExecutionSet)rs;
            }
            catch (Exception e)
            {
                throw new RuleExecutionSetCreateException("Internal error.", e);
            }
        }
    }
}
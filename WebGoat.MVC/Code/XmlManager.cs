using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace WebGoat.MVC.Code
{
    public class XmlManager
    {
        private XElement _root = null;

        public XmlManager(string xmlpath)
        {
            _root = XElement.Load(xmlpath);
        }

        /// <summary>
        /// Returns a list of urls.
        /// </summary>
        /// <returns></returns>
        public List<string> GetWhiteList()
        {
            if (_root == null)
                throw new NullReferenceException("_root");

            var list = _root.Elements("domain");
            List<string> domainList = new List<string>();
            foreach (var item in list)
            {
                domainList.Add(item.Attribute("url").Value);
            }

            return domainList;
        }

        /// <summary>
        /// Returns a single url based on the incoming code.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string GetWhiteList(string code)
        {
            if (string.IsNullOrEmpty(code))
                throw new ArgumentNullException("code");

            var node = _root.Elements("domain").Where(n => n.Attribute("code").Value == code).SingleOrDefault();

            if (node == null)
                throw new NullReferenceException("node");

            return node.Attribute("url").Value;
        }
    }
}
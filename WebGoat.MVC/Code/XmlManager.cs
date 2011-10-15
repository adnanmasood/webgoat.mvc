using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebGoat.MVC.Code
{
    public class XmlManager
    {
        private XElement _root;

        public XmlManager(string xmlpath)
        {
            _root = XElement.Load(xmlpath);
        }

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
    }
}
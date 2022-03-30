using System.Xml;
using Newtonsoft.Json;
using KellermanSoftware.CompareNetObjects;
using AEOI.Editor.Web.Shared.Models;

namespace AEOI.Editor.Web.Shared
{
    public class ComparisonService
    {
        private XmlDiffLibrary xmlDiffLibrary;

        public ComparisonService()
        {
            xmlDiffLibrary = new XmlDiffLibrary();
        }

        //Compare two XML Documents
        public string CompareXml(XmlDocument previousXml, XmlDocument currentXml)
        {
            var diff = new XmlDiffLibrary.XmlDiff(previousXml.OuterXml, currentXml.OuterXml);
            diff.CompareDocuments(new XmlDiffLibrary.XmlDiffOptions()
            {
                TwoWayMatch=true,
                TrimWhitespace=true,
                IgnoreNamespace=true,
                IgnoreAttributeOrder=true,
                IgnoreChildOrder=true
            });
            return diff.ToString();
        }
    }
}

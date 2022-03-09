using System.Xml;
using Newtonsoft.Json;
using KellermanSoftware.CompareNetObjects;

namespace AEOI.Editor.Web.Shared
{
    public class ComparisonService
    {
       
        // Compare Two Objects
        public string CompareObjects(File previousDocument, File currentDocument)
        {
            // Used package for object comparison : KellermanSoftware.CompareNetObjects
            CompareLogic compareLogic = new CompareLogic();
            compareLogic.Config.MaxDifferences = 100;
            ComparisonResult result = compareLogic.Compare(previousDocument, currentDocument);

            //Convert the differences list to json string
            var json = JsonConvert.SerializeObject(result.Differences);

            return json;
        }

        public string CompareAccounts(FileAccounts previousDocument, FileAccounts currentDocument)
        {
            // Used package for object comparison : KellermanSoftware.CompareNetObjects
            CompareLogic compareLogic = new CompareLogic();
            compareLogic.Config.MaxDifferences = 100;
            ComparisonResult result = compareLogic.Compare(previousDocument, currentDocument);

            //Convert the differences list to json string
            var json = JsonConvert.SerializeObject(result.Differences);

            return json;
        }
        public string CompareFis(FileFIs previousDocument, FileFIs currentDocument)
        {
            // Used package for object comparison : KellermanSoftware.CompareNetObjects
            CompareLogic compareLogic = new CompareLogic();
            compareLogic.Config.MaxDifferences = 100;
            ComparisonResult result = compareLogic.Compare(previousDocument, currentDocument);

            //Convert the differences list to json string
            var json = JsonConvert.SerializeObject(result.Differences);

            return json;
        }



        private XmlDiffLibrary xmlDiffLibrary = new XmlDiffLibrary();

        //Compare two XML Documents
        public string CompareXml(XmlDocument previousXml, XmlDocument currentXml)
        {
            var diff = new XmlDiffLibrary.XmlDiff(previousXml.OuterXml, currentXml.OuterXml);
            diff.CompareDocuments(new XmlDiffLibrary.XmlDiffOptions());
            return diff.ToString();
        }
    }
}

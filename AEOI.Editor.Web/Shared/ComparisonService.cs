using JsonDiffPatchDotNet;
using Microsoft.XmlDiffPatch;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Xml;
using XmlDiffLib;
using KellermanSoftware.CompareNetObjects;

namespace AEOI.Editor.Web.Shared
{
    public class ComparisonService
    {
        public string CompareObjects(Report previousDocument, Report currentDocument)
        {
            //This is the comparison class
            CompareLogic compareLogic = new CompareLogic();
            compareLogic.Config.MaxDifferences = 100;
            ComparisonResult result = compareLogic.Compare(previousDocument, currentDocument);

            var json = JsonConvert.SerializeObject(result.Differences);

            //These will be different, write out the differences
            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);
            return json;
        }

        public string CompareXml(XmlDocument previousXml, XmlDocument currentDocument)
        {
            XmlWriter diffgramWriter = new XmlTextWriter("diffgram.xml", new System.Text.UnicodeEncoding());

            Microsoft.XmlDiffPatch.XmlDiff xmlDiff = new Microsoft.XmlDiffPatch.XmlDiff();
            // set the comparison algorithm - auto algorithm is depending on the size and assumed number of changes in the compared documents.
            xmlDiff.Algorithm = XmlDiffAlgorithm.Auto;
            xmlDiff.IgnoreComments = true;
            xmlDiff.IgnoreComments = true;
            xmlDiff.IgnoreWhitespace = true;

            bool isSame = xmlDiff.Compare(previousXml.DocumentElement, currentDocument.DocumentElement, diffgramWriter);
            diffgramWriter.Flush();
            diffgramWriter.Close();


            return isSame == true ? "NoDiff" : "HasDiff";
        }

        //Compared with package : nils-org/XmlComparer
        public string CompareXmlFiles(XmlDocument previousXml, XmlDocument currentDocument)
        {
            var comparer = new XmlComparer.Comparer(
               ignoreAttributeOrder: true,
               ignoreNamespace: true);
            var differences = comparer.GetDifferences(previousXml, currentDocument);

            return "ok";
        }
        //Compared with package :BrutalSimplicity/XmlDiffLib

        public string CompareXmls(XmlDocument previousXml, XmlDocument currentDocument)
        {

            var diff = new XmlDiffLib.XmlDiff(previousXml.OuterXml, currentDocument.OuterXml);
            diff.CompareDocuments(new XmlDiffLib.XmlDiffOptions());

            return diff.ToString();
        }

        public string XmlConvertToJsonAndCompare(XmlDocument previousXml, XmlDocument currentDocument)
        {
            string previousJson = JsonConvert.SerializeXmlNode(previousXml);
            string currentJson = JsonConvert.SerializeXmlNode(currentDocument);

            var jdp = new JsonDiffPatch();

            var left = JToken.Parse(previousJson);
            var right = JToken.Parse(currentJson);
            JToken patch = jdp.Diff(left, right);

            var output = jdp.Unpatch(right, patch);

            Console.WriteLine(output.ToString());


            return output.ToString();
        }
    }
}

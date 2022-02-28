using System.Xml;
using Microsoft.XmlDiffPatch;

namespace AEOI.Editor.Web.Shared
{
    public class ComparisonService
    {
        public string CompareObjects(AEOIUKSubmissionFIReport previousDocument, AEOIUKSubmissionFIReport currentDocument)
        {
            return "Ok";
        }
        public string CompareXml(XmlDocument previousXml, XmlDocument currentDocument)
        {
            XmlWriter diffgramWriter = new XmlTextWriter("diffgram.xml", new System.Text.UnicodeEncoding());

            XmlDiff xmlDiff = new XmlDiff();
            // set the comparison algorithm - auto algorithm is depending on the size and assumed number of changes in the compared documents.
            xmlDiff.Algorithm = XmlDiffAlgorithm.Auto;

            bool isSame = xmlDiff.Compare(previousXml.DocumentElement, currentDocument.DocumentElement, diffgramWriter);
            diffgramWriter.Flush();
            diffgramWriter.Close();

            return isSame == true?"NoDiff":"HasDiff";
        }
    }
}

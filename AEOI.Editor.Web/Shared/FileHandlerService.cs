using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AEOI.Editor.Web.Shared
{
    public class FileHandlerService
    {
        public AEOIUKSubmissionFIReport ReadFile(string filePath,string fileName)
        {
            //var path = Path.Combine("/tmp", "Uploads", fileName);
            var path = Path.Combine(filePath, "Uploads", fileName);

            //Logger.LogInformation("upload file path @{path}", path);

            XmlSerializer serializer = new XmlSerializer(typeof(AEOIUKSubmissionFIReport));

            StreamReader reader = new StreamReader(path);
            var report = (AEOIUKSubmissionFIReport)serializer.Deserialize(reader);
            reader.Close();
            return report;
        }
    }
}

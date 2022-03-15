using AEOI.Editor.Web.Shared;
using AEOI.Editor.Web.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace AEOI.Editor.Web.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ComparisonController : ControllerBase
    {
        public string fileName = "fiveFis.xml";
        public bool IsLarge = false;
        private readonly ILogger<UploadController> logger;
        private ComparisonService comparisonService;
        private PDFGenerator pdfGenerator;
        public ComparisonController(ILogger<UploadController> logger)
        {
            this.logger = logger;

            this.comparisonService = new ComparisonService();
        }

        [HttpPost]
        public IActionResult Compare(IFormFile file)
        {

            string userName = "Allie Grater";
            string dateOfFileModified = "02/03/2022";
            string timeOfFileModified = "09.32 AM";

            try
            {
                // Read The existing file
                var path = Path.Combine("/tmp", "Uploads", fileName);
                string fullpath = Path.GetFullPath(path);

                XmlRootAttribute xRoot = new XmlRootAttribute();
                xRoot.ElementName = "File";
                //xRoot.Namespace = "http://www.cpandl.com";
                xRoot.IsNullable = true;

                XmlSerializer serializer = new XmlSerializer(typeof(File), xRoot);

                StreamReader reader = new StreamReader(path);
                var previousFile = (File)serializer.Deserialize(reader);
                reader.Close();

                //get the snapShot name from file name
                var fileContent = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
                var newFileName = Path.GetFileName(fileContent.FileName.ToString().Trim('"'));
                string[] splitNames = newFileName.Split(' ', '.');
                string snapShotName = splitNames.Length > 2 ? splitNames[splitNames.Length - 2] : "N/A";


                // Convert the currentFile to object
                File currentFile = (File)serializer.Deserialize(file.OpenReadStream());

                string workFlowName = currentFile.fileName;
                FileSubmissions submission = currentFile.Submissions;
                FileAccounts currentAccounts = currentFile.Accounts;
                FileAccounts previousAccounts = previousFile.Accounts;
                //############# objects comparison #############
                //string accountDifference = comparisonService.CompareAccounts(currentAccounts, previousAccounts);

                FileFIs currentFis = currentFile.FIs;
                FileFIs previousFis = previousFile.FIs;
                //string fiDifference = comparisonService.CompareFis(currentFis, previousFis);

                // Compare the differences two of objects | returns json string
                //string response = comparisonService.CompareObjects(previousFile, currentFile);   

                //############# Two XML comparison #############
                XmlDocument currentAccountXml = SerializeToXmlDocument(currentAccounts);
                XmlDocument previousAccountXml = SerializeToXmlDocument(previousAccounts);
                string xmlAccountDifference = comparisonService.CompareXml(previousAccountXml,currentAccountXml);
                // Deserilize to string to object
                XmlDifference accountDifferenceAsObject = JsonConvert.DeserializeObject<XmlDifference>(xmlAccountDifference);

                XmlDocument currentFiXml = SerializeToXmlDocument(currentFis);
                XmlDocument previousFiXml = SerializeToXmlDocument(previousFis);
                string xmlFiDifference = comparisonService.CompareXml(previousFiXml, currentFiXml);

                // Deserilize to string to object
                XmlDifference fiDifferenceAsObject = JsonConvert.DeserializeObject<XmlDifference>(xmlFiDifference);


                // XMLDocument conversion
                XmlDocument currentXml = SerializeToXmlDocument(currentFile);
                XmlDocument previousXml = new XmlDocument();
                previousXml.Load(path);

                // Compare the differences two of XML | returns json string
                string response = comparisonService.CompareXml(previousXml, currentXml);

                //FileStreamResult fileStreamResult = pdfGenerator.Generate(response);
                XmlDifference xmlDifference = JsonConvert.DeserializeObject<XmlDifference>(response);

                //Initialize the PDFGenerator
                this.pdfGenerator = new PDFGenerator(userName, dateOfFileModified, timeOfFileModified, snapShotName, currentFile, currentFis);
                string fileSaveLocation = pdfGenerator.GeneratePdf(accountDifferenceAsObject.DiffNodeList, fiDifferenceAsObject.DiffNodeList);

                //return fileStreamResult;

                return Ok(fileSaveLocation);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return BadRequest();
            }
        }

        public XmlDocument SerializeToXmlDocument(object input)
        {
            XmlSerializer ser = new XmlSerializer(input.GetType());

            XmlDocument xd = null;

            using (MemoryStream memStm = new MemoryStream())
            {
                ser.Serialize(memStm, input);

                memStm.Position = 0;

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreWhitespace = true;

                using (var xtr = XmlReader.Create(memStm, settings))
                {
                    xd = new XmlDocument();
                    xd.Load(xtr);
                }
            }

            return xd;
        }


    }
}




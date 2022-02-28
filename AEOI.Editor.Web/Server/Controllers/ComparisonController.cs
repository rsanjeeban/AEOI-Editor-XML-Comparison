using AEOI.Editor.Web.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AEOI.Editor.Web.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ComparisonController : ControllerBase
    {
        public string fileName = "AEOI_ v2.0_Example_New_Submission 1.xml";
        public bool IsLarge = false;
        private readonly ILogger<UploadController> logger;
        private FileHandlerService fileHandlerService = new FileHandlerService();
        private ComparisonService comparisonService = new ComparisonService();
        public ComparisonController(ILogger<UploadController> logger)
        {
            this.logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Compare(IFormFile file)
        {
            try
            {
                var path = Path.Combine("/tmp", "Uploads", fileName);

                //logger.LogInformation("upload file path @{path}", path);

                XmlSerializer serializer = new XmlSerializer(typeof(AEOIUKSubmissionFIReport));

                //StreamReader reader = new StreamReader(path);
                //var previousFile = (AEOIUKSubmissionFIReport)serializer.Deserialize(reader);
                //reader.Close();

                //Convert the CurrentFile to Object
                AEOIUKSubmissionFIReport currentFile = (AEOIUKSubmissionFIReport)serializer.Deserialize(file.OpenReadStream());
                //string response = comparisonService.CompareObjects(previousFile, currentFile);
                XmlDocument currentXml = SerializeToXmlDocument(currentFile);
                XmlDocument previousXml = new XmlDocument();
                previousXml.Load(path);

                string response = comparisonService.CompareXml(currentXml, previousXml);



                return Ok(response);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                Response.WriteAsync(ex.Message);
                throw;
            }
        }

        public XmlDocument SerializeToXmlDocument(object input)
        {
            XmlSerializer ser = new XmlSerializer(input.GetType(), "http://hmrc.gov.uk/AEOIUKSubmissionFIReport");

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




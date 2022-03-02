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
        public string fileName = "AEOI CDF1.xml";
        public bool IsLarge = false;
        private readonly ILogger<UploadController> logger;
        private ComparisonService comparisonService = new ComparisonService();
        public ComparisonController(ILogger<UploadController> logger)
        {
            this.logger = logger;
        }

        [HttpPost]
        public IActionResult Compare(IFormFile file)
        {
            try
            {
                // Read The existing file
                var path = Path.Combine("/tmp", "Uploads", fileName);
                string fullpath = Path.GetFullPath(path);

                XmlSerializer serializer = new XmlSerializer(typeof(Report));

                StreamReader reader = new StreamReader(path);
                var previousFile = (Report)serializer.Deserialize(reader);
                reader.Close();

                // Convert the currentFile to object
                Report currentFile = (Report)serializer.Deserialize(file.OpenReadStream());

                //############# Two objects comparison #############
                // Compare the differences two of objects | returns json string
                //string response = comparisonService.CompareObjects(previousFile, currentFile);   

                //############# Two XML comparison #############
                // XMLDocument conversion
                XmlDocument currentXml = SerializeToXmlDocument(currentFile);
                XmlDocument previousXml = new XmlDocument();
                previousXml.Load(path);

                // Compare the differences two of XML | returns json string
                string response = comparisonService.CompareXml(currentXml, previousXml);

                return Ok(response);
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




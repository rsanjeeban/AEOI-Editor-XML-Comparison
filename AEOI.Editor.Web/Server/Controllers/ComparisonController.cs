﻿using AEOI.Editor.Web.Shared;
using AEOI.Editor.Web.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        public string fileName = "fiveFis.snapshotV1.xml";
        public bool IsLarge = false;
        private readonly ILogger<UploadController> logger;
        private ComparisonService comparisonService;
        private FileGenerator fileGenerator;
        public ComparisonController(ILogger<UploadController> logger)
        {
            this.logger = logger;

            this.comparisonService = new ComparisonService();
        }
        [HttpPost]
        public async Task<IActionResult> ExportPdf(String[] fileNames, String export)
        {
            List<DifferenceList> differenceList = new List<DifferenceList>();
            
            for (int i = 0; i < fileNames.Length; i++)
            {
                if (i+1 < fileNames.Length)
                {
                    differenceList.Add(Compare(fileNames[i], fileNames[i + 1],"pdf"));
                }
            }

            //Defined the List to merge the seperate difference list into one
            DifferenceList mergedDifferenceList = new DifferenceList(new XmlDifference(), new XmlDifference());
            mergedDifferenceList.FiDifference.DiffNodeList = new List<Difference>();
            mergedDifferenceList.AccountDifference.DiffNodeList = new List<Difference>();

            //Merge the array of list into single list
            for (int i = 0; i < differenceList.Count; i++)
            {
                mergedDifferenceList.FiDifference.DiffNodeList.AddRange(differenceList[i].FiDifference.DiffNodeList);
                mergedDifferenceList.AccountDifference.DiffNodeList.AddRange(differenceList[i].AccountDifference.DiffNodeList);
            }

            return Ok(JsonConvert.SerializeObject(mergedDifferenceList));
        }


        public DifferenceList Compare(String file1Name, String file2Name,String export="pdf")
        {
            string userName = "Allie Grater";
            string dateOfFileModified = "02/03/2022";
            string timeOfFileModified = "09.32 AM";

            try
            {
                // Read The existing file
                var file1Path = Path.Combine("/tmp", "Uploads", file1Name);
                var file2Path = Path.Combine("/tmp", "Uploads", file2Name);
                //string fullpath = Path.GetFullPath(file1Path);

                XmlRootAttribute xRoot = new XmlRootAttribute();
                xRoot.ElementName = "File";
                //xRoot.Namespace = "http://www.cpandl.com";
                xRoot.IsNullable = true;

                XmlSerializer serializer = new XmlSerializer(typeof(File), xRoot);

                StreamReader reader = new StreamReader(file1Path);
                var file1 = (File)serializer.Deserialize(reader);

                reader = new StreamReader(file2Path);
                var file2 = (File)serializer.Deserialize(reader);
                reader.Close();

                //get the snapShot name from file name
                string[] splitNames = file2Name.Split(' ', '.');
                string snapShotName = splitNames.Length > 2 ? splitNames[splitNames.Length - 2] : "N/A";

                //// Convert the currentFile to object
                //File currentFile = (File)serializer.Deserialize(file.OpenReadStream());

                string workFlowName = file2.fileName;
                FileSubmissions submission = file2.Submissions;
                FileAccounts currentAccounts = file2.Accounts;
                FileAccounts previousAccounts = file1.Accounts;

                string fiDifference = comparisonService.CompareFis(file2.FIs, file1.FIs);

                //############# Two XML comparison #############
                XmlDocument currentAccountXml = SerializeToXmlDocument(file2.Accounts);
                XmlDocument previousAccountXml = SerializeToXmlDocument(file1.Accounts);
                string xmlAccountDifference = comparisonService.CompareXml(previousAccountXml, currentAccountXml);
                // Deserilize to string to object
                XmlDifference accountDifferenceAsObject = JsonConvert.DeserializeObject<XmlDifference>(xmlAccountDifference);

                XmlDocument currentFiXml = SerializeToXmlDocument(file2.FIs);
                XmlDocument previousFiXml = SerializeToXmlDocument(file1.FIs);
                string xmlFiDifference = comparisonService.CompareXml(previousFiXml, currentFiXml);

                // Deserilize to string to object
                XmlDifference fiDifferenceAsObject = JsonConvert.DeserializeObject<XmlDifference>(xmlFiDifference);

                DifferenceList DifferenceList = new DifferenceList(fiDifferenceAsObject, accountDifferenceAsObject);
                //string fileSaveLocation;

                //Initialize the FileGenerator
                //fileGenerator = new FileGenerator(userName, dateOfFileModified, timeOfFileModified, snapShotName, file2, file2.FIs, accountDifferenceAsObject.DiffNodeList, fiDifferenceAsObject.DiffNodeList);

                //if (export == "excel")
                //{
                //    fileSaveLocation = fileGenerator.GenerateExcel();
                //}
                //else
                //{
                //    fileSaveLocation = fileGenerator.GeneratePdf();
                //}

                //return fileStreamResult;

                //return Ok(fileSaveLocation);
                return DifferenceList;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex);
                return null;
            }
        }

        //[HttpPost]
        //public IActionResult Compare(IFormFile file, String export)
        //{

        //    string userName = "Allie Grater";
        //    string dateOfFileModified = "02/03/2022";
        //    string timeOfFileModified = "09.32 AM";

        //    try
        //    {
        //        // Read The existing file
        //        var path = Path.Combine("/tmp", "Uploads", fileName);
        //        string fullpath = Path.GetFullPath(path);

        //        XmlRootAttribute xRoot = new XmlRootAttribute();
        //        xRoot.ElementName = "File";
        //        //xRoot.Namespace = "http://www.cpandl.com";
        //        xRoot.IsNullable = true;

        //        XmlSerializer serializer = new XmlSerializer(typeof(File), xRoot);

        //        StreamReader reader = new StreamReader(path);
        //        var previousFile = (File)serializer.Deserialize(reader);
        //        reader.Close();

        //        //get the snapShot name from file name
        //        var fileContent = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
        //        var newFileName = Path.GetFileName(fileContent.FileName.ToString().Trim('"'));
        //        string[] splitNames = newFileName.Split(' ', '.');
        //        string snapShotName = splitNames.Length > 2 ? splitNames[splitNames.Length - 2] : "N/A";


        //        // Convert the currentFile to object
        //        File currentFile = (File)serializer.Deserialize(file.OpenReadStream());

        //        string workFlowName = currentFile.fileName;
        //        FileSubmissions submission = currentFile.Submissions;
        //        FileAccounts currentAccounts = currentFile.Accounts;
        //        FileAccounts previousAccounts = previousFile.Accounts;
        //        //############# objects comparison #############
        //        //string accountDifference = comparisonService.CompareAccounts(currentAccounts, previousAccounts);

        //        FileFIs currentFis = currentFile.FIs;
        //        FileFIs previousFis = previousFile.FIs;
        //        //string fiDifference = comparisonService.CompareFis(currentFis, previousFis);

        //        // Compare the differences two of objects | returns json string
        //        //string response = comparisonService.CompareObjects(previousFile, currentFile);   

        //        //############# Two XML comparison #############
        //        XmlDocument currentAccountXml = SerializeToXmlDocument(currentAccounts);
        //        XmlDocument previousAccountXml = SerializeToXmlDocument(previousAccounts);
        //        string xmlAccountDifference = comparisonService.CompareXml(previousAccountXml, currentAccountXml);
        //        // Deserilize to string to object
        //        XmlDifference accountDifferenceAsObject = JsonConvert.DeserializeObject<XmlDifference>(xmlAccountDifference);

        //        XmlDocument currentFiXml = SerializeToXmlDocument(currentFis);
        //        XmlDocument previousFiXml = SerializeToXmlDocument(previousFis);
        //        string xmlFiDifference = comparisonService.CompareXml(previousFiXml, currentFiXml);

        //        // Deserilize to string to object
        //        XmlDifference fiDifferenceAsObject = JsonConvert.DeserializeObject<XmlDifference>(xmlFiDifference);


        //        // XMLDocument conversion
        //        XmlDocument currentXml = SerializeToXmlDocument(currentFile);
        //        XmlDocument previousXml = new XmlDocument();
        //        previousXml.Load(path);

        //        // Compare the differences two of XML | returns json string
        //        string response = comparisonService.CompareXml(previousXml, currentXml);

        //        XmlDifference xmlDifference = JsonConvert.DeserializeObject<XmlDifference>(response);

        //        string fileSaveLocation;

        //        //Initialize the FileGenerator
        //        fileGenerator = new FileGenerator(userName, dateOfFileModified, timeOfFileModified, snapShotName, currentFile, currentFis, accountDifferenceAsObject.DiffNodeList, fiDifferenceAsObject.DiffNodeList);


        //        if (export == "excel")
        //        {
        //            fileSaveLocation = fileGenerator.GenerateExcel();
        //        }
        //        else
        //        {
        //            fileSaveLocation = fileGenerator.GeneratePdf();
        //        }


        //        //return fileStreamResult;

        //        return Ok(fileSaveLocation);
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogError(ex.Message, ex);
        //        return BadRequest();
        //    }
        //}

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




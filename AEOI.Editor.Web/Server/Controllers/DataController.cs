using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.Extensions.Logging;
using AEOI.Editor.Web.Shared;

namespace AEOI.Editor.Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {

        public IWebHostEnvironment HostingEnvironment { get; set; }
        public ILogger<DataController> Logger { get; }
        private FileHandlerService fileHandlerService = new FileHandlerService();

        public DataController(IWebHostEnvironment hostingEnvironment, ILogger<DataController> logger)
        {
            HostingEnvironment = hostingEnvironment;
            Logger = logger;
        }

        [HttpGet("[action]")]
        public AEOIUKSubmissionFIReport GetData(string fileName, bool large, int records = 100)
        {
            try
            {
                var report = fileHandlerService.ReadFile("/tmp", fileName);

                if (large)
                {
                    report.Submission.FIReturn.AccountData = Enumerable.Range(0, records).Select(i =>
                    {
                        return report.Submission.FIReturn.AccountData[0];
                    }).ToArray();
                }

                return report;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message, ex);
                Response.WriteAsync(ex.Message);
                throw;
            }
          
        }
    }
}

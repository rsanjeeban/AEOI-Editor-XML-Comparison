using System;
using System.IO;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using AEOI.Editor.Web.Shared.Models;

namespace AEOI.Editor.Web.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UploadController : ControllerBase
    {
        private readonly ILogger<UploadController> logger;

        public UploadController(ILogger<UploadController> logger)
        {
            this.logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Save(IFormFile file) // must match SaveField which defaults to "files"
        {
            if (file != null)
            {
                try
                {
                    var fileContent = ContentDispositionHeaderValue.Parse(file.ContentDisposition);

                    // Some browsers send file names with full path.
                    // We are only interested in the file name.
                    var fileName = Path.GetFileName(fileContent.FileName.ToString().Trim('"'));

                    var directory = Path.Combine("/tmp", "Uploads");

                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    var physicalPath = Path.Combine(directory, fileName);

                    // Implement security mechanisms here - prevent path traversals,
                    // check for allowed extensions, types, size, content, viruses, etc.
                    // This sample always saves the file to the root and is not sufficient for a real application.

                    using (var fileStream = new FileStream(physicalPath, FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    // Implement error handling here, this example merely indicates an upload failure.
                    Response.StatusCode = 500;
                    await Response.WriteAsync(ex.Message); // custom error message
                }
            }

            // Return an empty string message in this case
            return new EmptyResult();
        }

        [HttpGet]
        public IEnumerable<FileDetail> GetFileNames()
        {
            DirectoryInfo d = new DirectoryInfo(@"/tmp/Uploads");
            FileInfo[] Files = d.GetFiles("*.xml");

            List<FileDetail> FileDetails = new List<FileDetail>();

            foreach (FileInfo file in Files)
            {
                FileDetails.Add(new FileDetail(file.Name,file.Length));
            }
            return FileDetails;
        }
    }

    
}

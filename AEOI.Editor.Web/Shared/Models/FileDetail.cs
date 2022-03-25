using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEOI.Editor.Web.Shared.Models
{
    public class FileDetail
    {
        public String fileName { get; set; }
        public long fileSize { get; set; }
        public bool isSelected { get; set; }

        public FileDetail(String fileName, long fileSize)
        {
            this.fileName = fileName;
            this.fileSize = fileSize;
            isSelected = false;
        }
    }

    public class SubmissionDetails
    {
        public String WorkflowName { get; set;}
        public String SendingCountry{ get; set;}
        public String ReportType{ get; set; }
        public String ReportStart { get; set; }
        public String ReportEnd { get; set; }

        public SubmissionDetails(File file)
        {
            WorkflowName = file.fileName;
            SendingCountry = file.Submissions.Submission.TransmittingCountry.Value;
            ReportType = file.Submissions.Submission.ReportType.Value;
            ReportStart = file.Submissions.Submission.ReportStart.ToString();
            ReportEnd = file.Submissions.Submission.ReportEnd.Value.ToString();
        }
    }
}

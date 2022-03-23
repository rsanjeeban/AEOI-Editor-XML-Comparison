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
}

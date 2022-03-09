using AEOI.Editor.Web.Shared.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
//using Syncfusion.Drawing;
using System.IO;
//using System;

namespace AEOI.Editor.Web.Shared
{
    public class PDFGenerator
    {
        private string userName;
        private string snapShotName;
        private string dateOfFileModified;
        private string timeOfFileModified;

        private FileFIs currentFis;
        private File currentFile;
        public PDFGenerator(string userName,string dateOfFileModified, string timeOfFileModified, string snapShotName, File file,FileFIs currentFis)
        {
            this.userName = userName;
            this.dateOfFileModified = dateOfFileModified;
            this.timeOfFileModified = timeOfFileModified;
            this.snapShotName = snapShotName;

            this.currentFile = file;
            this.currentFis = currentFis;
        }
        public void GeneratePdf(List<Difference> accountDifferences, List<Difference> fiDifferences)
        {
            
            MemoryStream workStream = new MemoryStream();

            DataTable dtblTableFi = MakeFiTable(fiDifferences);
            DataTable dtblTableAccount = MakeAccountsTable(accountDifferences);
            string strHeader = "Audit Trail Report";

            System.IO.FileStream fs = new FileStream(@"E:\test.pdf", FileMode.Create, FileAccess.Write, FileShare.None);

            Document document = new Document();
            PdfWriter.GetInstance(document, workStream).CloseStream = false;
            document.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 15, 1, BaseColor.BLACK);
            Chunk glue = new Chunk(new VerticalPositionMark());
            Font pageTitle = new Font(bfntHead, 22, 0, BaseColor.BLACK);
            Paragraph prgHeading = new Paragraph(strHeader, pageTitle);
            prgHeading.Add(new Chunk(glue));
            DateTime thisDay = DateTime.Today;
            Font fntDate = new Font(bfntHead, 12,0, BaseColor.BLACK);
            prgHeading.Add(new Chunk("Generated on : "+ thisDay.ToString("d"),fntDate));
            document.Add(prgHeading);

            //Add Report Details
            Font fntReportDetailsHead = new Font(bfntHead, 16, 2, BaseColor.BLACK);
            Paragraph paraTitleSub = new Paragraph("Submission Details", fntReportDetailsHead);
            paraTitleSub.SpacingBefore = 10;
            document.Add(paraTitleSub);
            
            Font fntReportDetails = new Font(bfntHead, 12, 2, BaseColor.BLACK);

            //Extract submission data
            FileSubmissions submission = currentFile.Submissions;
            FileSubmissionsSubmission submissionData = submission.Submission;
            
            //Get FileName
            string workFlowName = currentFile.fileName;

            document.Add(new Paragraph($"Workflow Name: - {workFlowName} ", fntReportDetails));
            document.Add(new Paragraph($"Sending Country: - {submissionData.TransmittingCountry.Value} ", fntReportDetails));
            document.Add(new Paragraph($"Report Type: - {submissionData.ReportType.Value} ", fntReportDetails));
            // Reporting period
            Paragraph paraPeriod = new Paragraph($"Reporting Period: - {submissionData.ReportStart.Value} to {submissionData.ReportEnd.Value}", fntReportDetails);
            paraPeriod.SpacingAfter = 10;
            
            document.Add(paraPeriod);

            //Text : FI
            Paragraph prgFi = new Paragraph();
            BaseFont btnFi = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntTableTitle = new Font(btnFi, 9, 2, BaseColor.GRAY);
            prgFi.Alignment = Element.ALIGN_LEFT;
            prgFi.Add(new Chunk("FI", fntTableTitle));
            document.Add(prgFi);

            //Add line break
            document.Add(new Paragraph("\n"));

            //Add Table 2 for "FI"

            //Write the table
            PdfPTable tableFi = new PdfPTable(dtblTableFi.Columns.Count);
            // Defiles the relative width of the columns
            //float[] tableFiColumnWidths = new float[] { 2f, 6f, 6f, 10f, 10f, 10f, 10f, 10f, 10f, 10f };
            //tableFi.SetTotalWidth(tableFiColumnWidths);

            tableFi.WidthPercentage = 100;
            Font fntTable = new Font(bfntHead, 9, 0, BaseColor.BLACK);

            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, BaseColor.WHITE);

            for (int i = 0; i < dtblTableFi.Columns.Count; i++)
            {
                //Skip the time field due to colspan
                if (dtblTableFi.Columns[i].ColumnName != "Time")
                {
                    PdfPCell cell = new PdfPCell(new Paragraph(dtblTableFi.Columns[i].ColumnName, fntTable));
                    cell.BorderWidth = 1;
                    //Colspan for date field
                    if (dtblTableFi.Columns[i].ColumnName == "Date")
                    {
                        cell.Colspan = 2;
                    }
                    tableFi.AddCell(cell);
                }
            }
            //table Data
            for (int i = 0; i < dtblTableFi.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTableFi.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Paragraph(dtblTableFi.Rows[i][j].ToString(), fntTable));
                    cell.BorderWidth = 1;
                    tableFi.AddCell(cell);
                }
            }

            document.Add(tableFi);

            //Text : Account
            Paragraph prgAccount = new Paragraph();
            prgAccount.Alignment = Element.ALIGN_LEFT;
            Paragraph ParaAccountTitle = new Paragraph("Account", fntTableTitle);
            ParaAccountTitle.SpacingBefore = 10;
            ParaAccountTitle.SpacingAfter = 15;
            prgAccount.Add(ParaAccountTitle);
            document.Add(prgAccount);

            // Add Table 2 for "Accounts"

            ////Write the table
            PdfPTable tableAccount = new PdfPTable(dtblTableAccount.Columns.Count);
            tableAccount.WidthPercentage = 100;

            //Table header
            BaseFont btnColumnHeader1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader1 = new Font(btnColumnHeader1, 10, 1, BaseColor.WHITE);

            for (int i = 0; i < dtblTableAccount.Columns.Count; i++)
            {
                //Skip the time field due to colspan
                if (dtblTableAccount.Columns[i].ColumnName != "Time")
                {
                    PdfPCell cell = new PdfPCell(new Paragraph(dtblTableAccount.Columns[i].ColumnName, fntTable));
                    cell.BorderWidth = 1;
                    // Colspan for date field
                    if (dtblTableAccount.Columns[i].ColumnName == "Date")
                    {
                        cell.Colspan = 2;
                    }
                    tableAccount.AddCell(cell);
                }

            }
            //table Data
            for (int i = 0; i < dtblTableAccount.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTableAccount.Columns.Count; j++)
                {
                    //tableAccount.AddCell(dtblTableAccount.Rows[i][j].ToString());
                    PdfPCell cell = new PdfPCell(new Paragraph(dtblTableAccount.Rows[i][j].ToString(), fntTable));
                    cell.BorderWidth = 1;
                    tableAccount.AddCell(cell);
                }
            }

            document.Add(tableAccount);



            document.Close();

            byte[] byteInfo = workStream.ToArray();
            workStream.Write(byteInfo, 0, byteInfo.Length);
            workStream.Position = 0;

            writer.Close();
            fs.Close();

            //return new FileStreamResult(workStream, "application/pdf");
        }

        DataTable MakeFiTable(List<Difference> differences)
        {
            //Create fi table object
            DataTable differentTable = new DataTable();

            //Define columns
            differentTable.Columns.Add("Item");
            differentTable.Columns.Add("Date");
            differentTable.Columns.Add("Time");
            differentTable.Columns.Add("Username ");
            differentTable.Columns.Add("FI Reference");
            differentTable.Columns.Add("FI Name");
            differentTable.Columns.Add("Event");
            differentTable.Columns.Add("Field Name");
            differentTable.Columns.Add("Previous Value");
            differentTable.Columns.Add("New Value");
            differentTable.Columns.Add("Snapshot version");

            //Populate with data
            int autoIncrement=0;

            differences.ForEach(item =>
            {
                // Convert the account object to string
                FileFIsFI Fi = JsonConvert.DeserializeObject<FileFIsFI> (item.Fi);
                autoIncrement++;
                differentTable.Rows.Add(autoIncrement, dateOfFileModified, timeOfFileModified, userName, Fi.FIID.Value, Fi.Name.Value, CheckEvent(item.ValueFrom, item.ValueTo), item.LocalName, item.ValueFrom, item.ValueTo, snapShotName);
            });

            return differentTable;
        }

        DataTable MakeAccountsTable(List<Difference> differences)
        {
            //Create account table object
            DataTable fiTable = new DataTable();

            //Define columns
            fiTable.Columns.Add("Item");
            fiTable.Columns.Add("Date");
            fiTable.Columns.Add("Time");
            fiTable.Columns.Add("Username ");
            fiTable.Columns.Add("FI Reference");
            fiTable.Columns.Add("FI Name");
            fiTable.Columns.Add("Account Number");
            fiTable.Columns.Add("Name of account holder /Controlling person");
            fiTable.Columns.Add("Event");
            fiTable.Columns.Add("Field Name");
            fiTable.Columns.Add("Previous Value");
            fiTable.Columns.Add("New Value");
            fiTable.Columns.Add("Snapshot version");

            //Populate with data
            int autoIncrement = 0;
            differences.ForEach(item =>
            {
                // Convert the account object to string
                FileAccountsAccount Account = JsonConvert.DeserializeObject<FileAccountsAccount>(item.Account);

                autoIncrement++;
                fiTable.Rows.Add(autoIncrement, dateOfFileModified, timeOfFileModified, userName, Account.FIID.Value, FindFiName(Account.FIID.Value), Account.AccountNumber.Value, Account.PersonType.Value, CheckEvent(item.ValueTo, item.ValueFrom),  item.LocalName, item.ValueTo, item.ValueFrom, snapShotName);
            });

            return fiTable;
        }

        private string FindFiName(string FIID)
        {
            string fiName=null;
            foreach (FileFIsFI Fi in currentFis.FI){
                if (Fi.FIID.Value == FIID)
                {
                    fiName = Fi.Name.Value;
                    break;
                }
            }
            return fiName;
        }

        public string CheckEvent(string From, string To)
        {
            if (To == "" | To == null)
            {
                return "Delete";
            }
            if (From == To)
            {
                return "N/A";
            }
            return "Edit";
        }
        
    }
}


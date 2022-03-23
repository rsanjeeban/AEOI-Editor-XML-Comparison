using AEOI.Editor.Web.Shared.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Data;
using System.Net;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace AEOI.Editor.Web.Shared
{
    public class FileGenerator
    {
        private string userName;
        private string snapShotName;
        private string dateOfFileModified;
        private string timeOfFileModified;

        private FileFIs currentFis;
        private File currentFile;

        private DataTable dtblTableFi;
        private DataTable dtblTableAccount;
        private DataTable dtblTableNewAccount;
        private DataTable dtblTableDeletedAccount;

        public FileGenerator(string userName, string dateOfFileModified, string timeOfFileModified, string snapShotName, File file, FileFIs currentFis, List<Difference> accountDifferences, List<Difference> fiDifferences)
        {
            this.userName = userName;
            this.dateOfFileModified = dateOfFileModified;
            this.timeOfFileModified = timeOfFileModified;
            this.snapShotName = snapShotName;

            this.currentFile = file;
            this.currentFis = currentFis;

            // Define the data tables
            this.dtblTableFi = MakeFiTable(fiDifferences);
            this.dtblTableAccount = MakeAccountsTable(accountDifferences);
            this.dtblTableNewAccount = MakeAccountsTable(accountDifferences, true);
            this.dtblTableDeletedAccount = MakeAccountsTable(accountDifferences, false, true);
        }
        public string GeneratePdf()
        {
            //string fileSaveLocation = "E:\\test.pdf";
            string fileSaveLocation = Path.GetFullPath(".\\pdf\\report.pdf");
            var appBaseUrl = MyHttpContext.AppBaseUrl;
            String fileUrl = appBaseUrl + "\\pdf\\report.pdf";

            MemoryStream workStream = new MemoryStream();

            string strHeader = "Audit Trail Report";

            FileStream fs = new FileStream(@fileSaveLocation, FileMode.Create, FileAccess.Write, FileShare.None);

            Document document = new Document();
            PdfWriter.GetInstance(document, workStream).CloseStream = false;
            document.SetPageSize(PageSize.A4.Rotate());
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
            Font fntDate = new Font(bfntHead, 12, 0, BaseColor.BLACK);
            prgHeading.Add(new Chunk("Generated on : " + thisDay.ToString("d"), fntDate));
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
            Paragraph paragraphPeriod = new Paragraph($"Reporting Period: - {submissionData.ReportStart.Value} to {submissionData.ReportEnd.Value}", fntReportDetails);
            paragraphPeriod.SpacingAfter = 10;

            document.Add(paragraphPeriod);

            // Define Font
            BaseFont btnFi = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntTableTitle = new Font(btnFi, 9, 2, BaseColor.GRAY);
            Font fntTable = new Font(bfntHead, 9, 0, BaseColor.BLACK);
            

            /* ------------------------ Add Table 1 for "FI" ------------------------ */

            if (dtblTableFi.Rows.Count != 0)
            {
                //Text : FI
                Paragraph prgFi = new Paragraph();
                
                prgFi.Alignment = Element.ALIGN_LEFT;
                prgFi.Add(new Chunk("FI", fntTableTitle));
                document.Add(prgFi);

                // Add line break
                document.Add(new Paragraph("\n"));

                // Write the table FI
                PdfPTable tableFi = new PdfPTable(dtblTableFi.Columns.Count);
                // Defiles the relative width of the columns
                // float[] tableFiColumnWidths = new float[] { 2f, 6f, 6f, 10f, 10f, 10f, 10f, 10f, 10f, 10f };
                // tableFi.SetTotalWidth(tableFiColumnWidths);

                tableFi.WidthPercentage = 90;
                tableFi.HorizontalAlignment = Element.ALIGN_LEFT;
               
                //Table header
                BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, BaseColor.WHITE);

                for (int i = 0; i < dtblTableFi.Columns.Count; i++)
                {
                    //Skip the 'time' field due to colspan
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

                // 'Fi' table Data
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
            }


            /* ------------------------ Add Table 2 for "Accounts" ------------------------ */
            
            if (dtblTableAccount.Rows.Count != 0)
            {
                //Text : Account
                Paragraph prgAccount = new Paragraph();
                prgAccount.Alignment = Element.ALIGN_LEFT;
                Paragraph ParaAccountTitle = new Paragraph("Account", fntTableTitle);
                ParaAccountTitle.SpacingBefore = 10;
                ParaAccountTitle.SpacingAfter = 15;
                prgAccount.Add(ParaAccountTitle);
                document.Add(prgAccount);

                //Write the account table
                PdfPTable tableAccount = new PdfPTable(dtblTableAccount.Columns.Count);
                tableAccount.WidthPercentage = 100;

                //Table header
                BaseFont btnColumnHeader1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntColumnHeader1 = new Font(btnColumnHeader1, 10, 1, BaseColor.WHITE);

                for (int i = 0; i < dtblTableAccount.Columns.Count; i++)
                {
                    //Skip the 'time' field due to colspan
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
                // 'account' table Data
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
            }


            /* ------------------------ Add Table 3 for "New Accounts" ------------------------ */

            if (dtblTableNewAccount.Rows.Count != 0)
            {
                // Text : Account
                Paragraph prgNewAccount = new Paragraph();
                prgNewAccount.Alignment = Element.ALIGN_LEFT;
                Paragraph ParaNewAccountTitle = new Paragraph("New Accounts", fntTableTitle);
                ParaNewAccountTitle.SpacingBefore = 10;
                ParaNewAccountTitle.SpacingAfter = 15;
                prgNewAccount.Add(ParaNewAccountTitle);
                document.Add(prgNewAccount);

                // Write the table
                PdfPTable tableNewAccount = new PdfPTable(dtblTableNewAccount.Columns.Count);
                tableNewAccount.WidthPercentage = 100;

                // Table header
                BaseFont btnColumnHeader2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntColumnHeader2 = new Font(btnColumnHeader2, 10, 1, BaseColor.WHITE);

                for (int i = 0; i < dtblTableNewAccount.Columns.Count; i++)
                {
                    //Skip the time field due to colspan
                    if (dtblTableNewAccount.Columns[i].ColumnName != "Time")
                    {
                        PdfPCell cell = new PdfPCell(new Paragraph(dtblTableNewAccount.Columns[i].ColumnName, fntTable));
                        cell.BorderWidth = 1;
                        // Colspan for date field
                        if (dtblTableNewAccount.Columns[i].ColumnName == "Date")
                        {
                            cell.Colspan = 2;
                        }
                        tableNewAccount.AddCell(cell);
                    }

                }
                // Table Data
                for (int i = 0; i < dtblTableNewAccount.Rows.Count; i++)
                {
                    for (int j = 0; j < dtblTableNewAccount.Columns.Count; j++)
                    {
                        //tableAccount.AddCell(dtblTableNewAccount.Rows[i][j].ToString());
                        PdfPCell cell = new PdfPCell(new Paragraph(dtblTableNewAccount.Rows[i][j].ToString(), fntTable));
                        cell.BorderWidth = 1;
                        tableNewAccount.AddCell(cell);
                    }
                }

                document.Add(tableNewAccount);
            }

            /* ------------------------ Add Table 4 for "Deleted Accounts" ------------------------ */

            if (dtblTableDeletedAccount.Rows.Count != 0)
            {
                // Text : Account
                Paragraph prgDeletedAccount = new Paragraph();
                prgDeletedAccount.Alignment = Element.ALIGN_LEFT;
                Paragraph ParaDeletedAccountTitle = new Paragraph("Deleted Accounts", fntTableTitle);
                ParaDeletedAccountTitle.SpacingBefore = 10;
                ParaDeletedAccountTitle.SpacingAfter = 15;
                prgDeletedAccount.Add(ParaDeletedAccountTitle);
                document.Add(prgDeletedAccount);

                // Write the table
                PdfPTable tableNewAccount = new PdfPTable(dtblTableDeletedAccount.Columns.Count);
                tableNewAccount.WidthPercentage = 100;

                // Table header
                BaseFont btnColumnHeader3 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fntColumnHeader3 = new Font(btnColumnHeader3, 10, 1, BaseColor.WHITE);

                for (int i = 0; i < dtblTableDeletedAccount.Columns.Count; i++)
                {
                    //Skip the time field due to colspan
                    if (dtblTableDeletedAccount.Columns[i].ColumnName != "Time")
                    {
                        PdfPCell cell = new PdfPCell(new Paragraph(dtblTableDeletedAccount.Columns[i].ColumnName, fntTable));
                        cell.BorderWidth = 1;
                        // Colspan for date field
                        if (dtblTableDeletedAccount.Columns[i].ColumnName == "Date")
                        {
                            cell.Colspan = 2;
                        }
                        tableNewAccount.AddCell(cell);
                    }

                }
                // Table Data
                for (int i = 0; i < dtblTableDeletedAccount.Rows.Count; i++)
                {
                    for (int j = 0; j < dtblTableDeletedAccount.Columns.Count; j++)
                    {
                        //tableAccount.AddCell(dtblTableDeletedAccount.Rows[i][j].ToString());
                        PdfPCell cell = new PdfPCell(new Paragraph(dtblTableDeletedAccount.Rows[i][j].ToString(), fntTable));
                        cell.BorderWidth = 1;
                        tableNewAccount.AddCell(cell);
                    }
                }

                document.Add(tableNewAccount);
            }



            document.Close();

            //byte[] byteInfo = workStream.ToArray();
            //workStream.Write(byteInfo, 0, byteInfo.Length);
            //workStream.Position = 0;

            writer.Close();
            fs.Close();

            //return new FileStreamResult(workStream, "application/pdf");
            return fileSaveLocation;

            // Create a new WebClient instance.
            //using (WebClient myWebClient = new WebClient())
            //{
            //    //myStringWebResource = remoteUri + fileName;
            //    // Download the Web resource and save it into the current filesystem folder.
            //    myWebClient.DownloadFile(fileUrl, fileSaveLocation);
            //    return fileUrl;
            //}
            //WebClient myWebClient = new WebClient();
            //fileUrl = appBaseUrl + "/pdf/report.pdf";
            //myWebClient.DownloadFile(fileUrl, fileSaveLocation);

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
            int autoIncrement = 0;

            differences.ForEach(item =>
            {
                // Convert the account object to string
                FileFIsFI Fi = JsonConvert.DeserializeObject<FileFIsFI>(item.Fi);
                if (Fi != null)
                {
                    autoIncrement++;
                    differentTable.Rows.Add(autoIncrement, dateOfFileModified, timeOfFileModified, userName, Fi.FIID.Value, Fi.Name.Value, CheckEvent(item.ValueFrom, item.ValueTo), item.LocalName, item.ValueFrom, item.ValueTo, snapShotName);
                }
            });

            return differentTable;
        }

        DataTable MakeAccountsTable(List<Difference> differences, bool onlyNew = false, bool onlyDeleted = false)
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

            if (!onlyNew && !onlyDeleted)
            {
                fiTable.Columns.Add("Field Name");
                fiTable.Columns.Add("Previous Value");
                fiTable.Columns.Add("New Value");
            }
            fiTable.Columns.Add("Snapshot version");

            //Populate with data
            int autoIncrement = 0;
            differences.ForEach(item =>
            {
                // Convert the account : string to object
                FileAccountsAccount Account = JsonConvert.DeserializeObject<FileAccountsAccount>(item.Account);
                
                if (item.Edit == "Delete" && onlyDeleted)
                {
                    autoIncrement++;
                    fiTable.Rows.Add(autoIncrement, dateOfFileModified, timeOfFileModified, userName, Account.FIID.Value, FindFiName(Account.FIID.Value), Account.AccountNumber.Value, Account.PersonType.Value, item.Edit, snapShotName);
                }
                else if (item.Edit == "Edit" && !onlyNew && !onlyDeleted)
                {
                    autoIncrement++;
                    fiTable.Rows.Add(autoIncrement, dateOfFileModified, timeOfFileModified, userName, Account.FIID.Value, FindFiName(Account.FIID.Value), Account.AccountNumber.Value, Account.PersonType.Value, item.Edit, item.LocalName, item.ValueTo, item.ValueFrom, snapShotName);
                }
                else if (item.Edit == "Insert" && onlyNew)
                {
                    autoIncrement++;
                    fiTable.Rows.Add(autoIncrement, dateOfFileModified, timeOfFileModified, userName, Account.FIID.Value, FindFiName(Account.FIID.Value), Account.AccountNumber.Value, Account.PersonType.Value, item.Edit, snapShotName);
                }
            });

            return fiTable;
        }

        private string FindFiName(string FIID)
        {
            string fiName = null;
            foreach (FileFIsFI Fi in currentFis.FI)
            {
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



        /*-------------------- Generate Excel --------------------*/

        public string GenerateExcel()
        {
            string fileSaveLocation = Path.GetFullPath(".\\excel\\report.xls");
            Console.WriteLine("Triggered GenerateExcel");

            //Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            //if (xlApp == null)
            //{
            //    //logger.LogInformation("Excel is not properly installed!!");
            //    Console.WriteLine("Excel is not properly installed!!");
            //    return null;
            //}

            //Excel.Workbook xlWorkBook;
            //Excel.Worksheet xlWorkSheet;
            //object misValue = System.Reflection.Missing.Value;

            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            //// Column headings
            //for (var i = 0; i < dtblTableFi.Columns.Count; i++) {
            //    xlWorkSheet.Cells[1, i + 1] = dtblTableFi.Columns[i].ColumnName;
            //}

            //// rows
            //for (var i = 0; i < dtblTableFi.Rows.Count; i++) {
            //    // to do: format datetime values before printing
            //    for (var j = 0; j < dtblTableFi.Columns.Count; j++) {
            //        xlWorkSheet.Cells[i + 2, j + 1] = dtblTableFi.Rows[i][j];
            //    }
            //}

            ////Excel.Worksheet xlAccountWorkSheet;
            //xlWorkBook = xlApp.Workbooks.Add(misValue);
            //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);

            //// Column headings
            //for (var i = 0; i < dtblTableAccount.Columns.Count; i++)
            //{
            //    xlWorkSheet.Cells[1, i + 1] = dtblTableAccount.Columns[i].ColumnName;
            //}

            //// rows
            //for (var i = 0; i < dtblTableAccount.Rows.Count; i++)
            //{
            //    // to do: format datetime values before printing
            //    for (var j = 0; j < dtblTableAccount.Columns.Count; j++)
            //    {
            //        xlWorkSheet.Cells[i + 2, j + 1] = dtblTableAccount.Rows[i][j];
            //    }
            //}




            ////xlWorkSheet.Cells[1, 1] = "ID";
            ////xlWorkSheet.Cells[1, 2] = "Name";
            ////xlWorkSheet.Cells[2, 1] = "1";
            ////xlWorkSheet.Cells[2, 2] = "One";
            ////xlWorkSheet.Cells[3, 1] = "2";
            ////xlWorkSheet.Cells[3, 2] = "Two";


            //string fileSaveLocation = Path.GetFullPath(".\\excel\\report.xls");
            //Console.WriteLine("FileSaveLocation: " + fileSaveLocation);
            //xlWorkBook.SaveAs(fileSaveLocation, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            //xlWorkBook.Close(true, misValue, misValue);
            //xlApp.Quit();
            //return fileSaveLocation;


            Excel.Application ExcelApp = new Excel.Application();

            Excel.Workbook ExcelWorkBook = null;

            Excel.Worksheet ExcelWorkSheet = null;

            object misValue = System.Reflection.Missing.Value;

            ExcelApp.Visible = true;

            ExcelWorkBook = ExcelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);



            List<string> SheetNames = new List<string>();
            SheetNames.Add("FI");
            SheetNames.Add("Account Changes");
            SheetNames.Add("Added Accounts");
            SheetNames.Add("Deleted Details");
            

            try
            {
                for (int i = 1; i < 4; i++)
                    ExcelWorkBook.Worksheets.Add(); //Adding New sheet in Excel Workbook

                DataTable tempDataTable = null;
                for (int i = 0; i < 4; i++)
                {
                    switch (i)
                    {
                        case 0: tempDataTable = dtblTableFi;break;
                        case 1: tempDataTable = dtblTableAccount; break;
                        case 2: tempDataTable = dtblTableNewAccount; break;
                        case 3: tempDataTable = dtblTableDeletedAccount; break;
                        //default: null;
                    }

                    ExcelWorkSheet = ExcelWorkBook.Worksheets[i + 1];

                    addColumnsAndRows(ref ExcelWorkSheet, ref tempDataTable);

                    //Renaming the ExcelSheets
                    ExcelWorkSheet.Name = SheetNames[i];
                }

                
                Console.WriteLine("FileSaveLocation: " + fileSaveLocation);
                ExcelWorkBook.SaveAs(fileSaveLocation, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                ExcelWorkBook.Close(true, misValue, misValue);
                ExcelApp.Quit();
            }
            catch (Exception ex)
            {

            }
            return fileSaveLocation;
        }

        public void addColumnsAndRows(ref Excel.Worksheet ExcelWorkSheet, ref DataTable tempDataTable)
        {
            // Column headings
            for (var t = 0; t < tempDataTable.Columns.Count; t++)
            {
                ExcelWorkSheet.Cells[1, t + 1] = tempDataTable.Columns[t].ColumnName;
            }

            // rows
            for (var t = 0; t < tempDataTable.Rows.Count; t++)
            {
                // to do: format datetime values before printing
                for (var j = 0; j < tempDataTable.Columns.Count; j++)
                {
                    ExcelWorkSheet.Cells[t + 2, j + 1] = tempDataTable.Rows[t][j];
                }
            }
        }
    }
}
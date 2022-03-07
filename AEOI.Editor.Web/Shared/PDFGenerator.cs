using AEOI.Editor.Web.Shared.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
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
        public void Generate(string report)
        {
            //List<string> authors = new List<string>(5);
            //authors.Add("Mahesh Chand");
            //authors.Add("Chris Love");
            //authors.Add("Allen O'neill");
            //authors.Add("Naveen Sharma");
            //authors.Add("Monica Rathbun");
            //authors.Add("David McCarter");

            ////Create a new Document
            //using (PdfDocument pdfDocument = new PdfDocument())
            //{
            //    int paragraphAfterSpacing = 8;
            //    int cellMargin = 8;

            //    //Add page to the pdf document
            //    PdfPage page = pdfDocument.Pages.Add();

            //    //Create New Font
            //    PdfStandardFont font = new PdfStandardFont(PdfFontFamily.TimesRoman, 16);

            //    //Create a text element to draw a text in PDF page
            //    PdfTextElement title = new PdfTextElement("Audit Report", font, PdfBrushes.Black);
            //    PdfLayoutResult result = title.Draw(page, new PointF(0, 0));

            //    PdfStandardFont contentFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 12);
            //    PdfLayoutFormat format = new PdfLayoutFormat();
            //    format.Layout = PdfLayoutType.Paginate;

            //    //Create a Pdf
            //    PdfGrid pdfGrid = new PdfGrid();
            //    pdfGrid.Style.CellPadding.Left = cellMargin;
            //    pdfGrid.Style.CellPadding.Right = cellMargin;

            //    // Applyting built in style to the PDF grid
            //    pdfGrid.ApplyBuiltinStyle(PdfGridBuiltinStyle.GridTable4Accent1);

            //    // Assigning Data Source
            //    //pdfGrid.DataSource = authors;

            //    pdfGrid.Style.Font = contentFont;

            //    // Draw Pdf Grid into Pdf Page
            //    //pdfGrid.Draw(page, new PointF(0, result.Bounds.Bottom + paragraphAfterSpacing));
            //    pdfGrid.Draw(page, new PointF(0, 1));

            //    using (MemoryStream stream = new MemoryStream())
            //    {
            //        pdfDocument.Save(stream);
            //        pdfDocument.Close(true);
            //        //Download the PDF document in the browser
            //        FileStreamResult fileStreamResult = new FileStreamResult(stream, "application/pdf");

            //        fileStreamResult.FileDownloadName = "Sample.pdf";

            //        return fileStreamResult;
            //    }



        }

        public void GeneratePdf(List<Difference> differences)
        {
            MemoryStream workStream = new MemoryStream();

            DataTable dtblTableFi = MakeFiTable(differences);
            DataTable dtblTableAccount = MakeAccountsTable(differences);
            string strHeader = "Audit Trail Report ";

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

            document.Add(new Paragraph("Workflow Name: - CRS ", fntReportDetails));
            document.Add(new Paragraph("Sending Country: -ALB ", fntReportDetails));
            document.Add(new Paragraph("Report Type: - Correction ", fntReportDetails));
            // Reporting period
            Paragraph paraPeriod = new Paragraph("Reporting Period: - 2021-01-01 to 2021-12-31", fntReportDetails);
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
                autoIncrement++;
                differentTable.Rows.Add(autoIncrement, "-", "-", "-", "-", "-", "-", "-", item.ValueFrom, item.ValueTo, "-");
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
                autoIncrement++;
                fiTable.Rows.Add(autoIncrement, "-", "-", "-", "-","-", item.ValueFrom, item.ValueTo, "-", "-", "-", "-");
            });

            return fiTable;
        }
        
    }
}


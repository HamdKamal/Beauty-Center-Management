using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SamarPro.Reports;
using DevExpress.XtraReports.UI;
using SamarPro.CONTROLS;

namespace SamarPro.Views
{
    public partial class frmLogs : Form
    {
        DataTable DT = new DataTable();
        BusneisLayer BL = new BusneisLayer();
        TransationModule TR = new TransationModule();

        // void for generate Pdf File
        private void GeneratePDF()
        {
            
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter w = PdfWriter.GetInstance(doc, new FileStream(@"سجلات النظام.pdf", FileMode.Create));
            doc.Open();
            //Add border to page
            PdfContentByte content = w.DirectContent;
            iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(doc.PageSize);
            //customized border sizes
            rectangle.Left += doc.LeftMargin - 5;
            rectangle.Right -= doc.RightMargin - 5;
            rectangle.Top -= doc.TopMargin - 5;
            rectangle.Bottom += doc.BottomMargin - 5;
            content.SetColorStroke(BaseColor.BLACK); // setting the color of the border to black
            content.Rectangle(rectangle.Left, rectangle.Bottom, rectangle.Width, rectangle.Height);
            content.Stroke();

            //setting font type, font size and font color
            iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(
            FontFactory.COURIER_BOLD, 30, BaseColor.BLUE);
            Paragraph prg = new Paragraph();
            prg.Alignment = Element.ALIGN_CENTER; // adjust the alignment of the heading
            prg.Add(new Chunk("سجلات النظام", font)); //adding a heading to the PDF
            doc.Add(prg); //add the component we created to the document
                          //specify the location of the logo
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(
                                                                @"images.png");
            image.Alignment = iTextSharp.text.Image.ALIGN_LEFT; //image alignments
            image.ScaleToFit(60f, 60f); //setting the width and height of the image
            doc.Add(image);

            PdfPTable table = new PdfPTable(Grid_Logs.Columns.Count);

            for (int j = 0; j < Grid_Logs.Columns.Count; j++)
            {
                PdfPCell cell = new PdfPCell(); //create object from the pdfpcell class
                cell.BackgroundColor = BaseColor.BLUE; //set color of cells to gray
                cell.AddElement(new Chunk(Grid_Logs.Columns[j].HeaderText.ToUpper(), font));
                table.AddCell(cell);
            }
            //add actual rows from grid to table
            for (int i = 0; i < Grid_Logs.Rows.Count; i++)
            {
                table.WidthPercentage = 100; //set width of the table
                for (int k = 0; k < Grid_Logs.Columns.Count; k++)
                {
                    if (Grid_Logs[k, i].Value != null)
                        // get the value of   each cell in the dataTable tblemp
                        table.AddCell(new Phrase(Grid_Logs[k, i].Value.ToString()));
                }
            }
            //add the table to document
            doc.Add(table);
            doc.Close();

        }


        public void COM_ID()  // fill combobox from data base
        {
            comb_type.DataSource = BL.get_username();
            comb_type.DisplayMember = "Name";
            comb_type.ValueMember = "ID";
        }

        void All_Logs()
        {
            
            DT = BL.Get_All_Logs();
            Grid_Logs.DataSource = DT;
        }
        public frmLogs()
        {
            InitializeComponent();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            COM_ID();
            All_Logs();
          
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حذف السجل المحدد!", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    db_model db = new db_model();
                    Logs ac = (from c in db.Logss where c.ID == Log_ID select c).FirstOrDefault();
                    db.Logss.Where(a => a.ID == Log_ID).Select(s => s).FirstOrDefault();
                    db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;

                    db.SaveChanges();
                    TR.Show_Message("تم حذف السجل ");
                    All_Logs();
                }
                else
                {
                    TR.Show_Message("تم إلغاء عملية الحذف");
                }
            }
            catch
            {
                return;
            }
           
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف كل السجلات", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                BL.DELETE_LOGS();
                TR.Show_Message("تم حذف كل السجلات ");
                All_Logs();
            }
            else
            {
                TR.Show_Message("تم إلغاء عملية الحذف");
            }
        }
        int Log_ID;
        private void Grid_Logs_Click(object sender, EventArgs e)
        {
            try
            {
                Log_ID = Convert.ToInt16(Grid_Logs.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                return;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                string s = comb_type.SelectedText;
                DateTime i = Sdate.Value;
                DateTime u = Edate.Value;
                DT = BL.Find_Logs(s, i, u);
                Grid_Logs.DataSource = DT;
            }
            catch
            {             
                TR.Show_Message(" ! الرجاء التأكد من صحة التاريخ ");
                return;
            }
        }
        
        private void btnPdf_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Logs_Report TK = new Logs_Report();
            TK.Parameters["BARCODE"].Value = comb_type.Text;
            TK.Parameters["EDATE"].Value = Edate.Value;
            TK.Parameters["SDATE"].Value = Sdate.Value;
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;

        }
    }
}

using DevExpress.XtraReports.UI;
using SamarPro.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamarPro.Views
{
    public partial class frmResource_POS : Form
    {
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
        CONTROLS.DataAccessLayer DAL = new CONTROLS.DataAccessLayer();
        DataTable dt = new DataTable();
        int Resource_ID;
        TransationModule TR = new TransationModule();
        string sql;
        SqlCommand CMD;
        SqlDataReader RED;
        void CLEAR_TEXT_BOX(Control CN)
        {
            foreach (Control C in CN.Controls)
                if (C is TextBox)
                    ((TextBox)C).Clear();
                else
                    CLEAR_TEXT_BOX(C);
        }
        void GET_BILLS_ID()
        {
            DataTable DT = new DataTable();
            DT = BL.get_Resourcebill_id();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            LBL_BILL_NO.Text = id.ToString();
        }
        public void get_prd_data(int R_id)
        {
            try
            {
                dt = BL.GET_ResourcePrdData(R_id);
                dgvRouc_pos.DataSource = dt;
            }
            catch
            {
                return;
            }
        }
        void Fill_ListView(int Bill_ID)
        {
            double totalprice;
            try
            {
                sql = "SELECT TC.BARCODE,P.NAME,TC.QUANTITY,isNull(P.Money,0) AS 'PRICE',TC.Total FROM Resource_Pos TC INNER JOIN Resource_Products P ON P.BARCODE = TC.BARCODE WHERE TC.BILL_ID = '" + LBL_BILL_NO.Text + "'";

                CMD = new SqlCommand(sql, DAL.Sqlconnection);
                DAL.open();
                RED = CMD.ExecuteReader();

                ListViewItem x;
                this.ListView1.Items.Clear();
                totalprice = 0;

                while (RED.Read())
                {
                    totalprice = totalprice + Convert.ToDouble(RED[4]);
                    x = new ListViewItem(RED[1].ToString());
                    x.SubItems.Add(RED[2].ToString());
                    x.SubItems.Add(RED[3].ToString());
                    x.SubItems.Add(RED[4].ToString());
                    x.SubItems.Add(RED[0].ToString());

                    this.ListView1.Items.Add(x);
                }

                {
                    var withBlock = this;
                    withBlock.LBL_TOTAL_PRICE.Text = String.Format(totalprice.ToString(), "N2").ToString();
                    withBlock.LBL_BILL_PRICE.Text = String.Format(totalprice.ToString(), "N2").ToString();
                }
            }
            catch
            {
                return;
            }
            finally
            {
                CMD.Dispose();
                DAL.close();
            }

        }
        void delete_order(int Code, int ID)
        {
            db_model db = new db_model();
            Resource_Pos ac = (from c in db.Resource_Poss where c.Barcode == Code && c.Bill_ID == ID select c).FirstOrDefault();
            db.Resource_Poss.Where(a => a.Barcode == Code && a.Bill_ID == ID).Select(s => s).FirstOrDefault();
            db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
        void Minimaze_Quantity(int BarCode)
        {
            db_model db = new db_model();
            Resource_Products ac = (from c in db.Resource_Productss where c.Barcode == BarCode select c).FirstOrDefault();
            db.Resource_Productss.Where(s => s.Barcode == BarCode).Select(s => s).FirstOrDefault();
            ac.Quantity = ac.Quantity - Convert.ToInt32(txt_Quantity.Text);
            db.SaveChanges();
        }
        void MaxMaize_Quantity(int BarCode)
        {
            db_model db = new db_model();
            Resource_Products ac = (from c in db.Resource_Productss where c.Barcode == BarCode select c).FirstOrDefault();
            db.Resource_Productss.Where(s => s.Barcode == BarCode).Select(s => s).FirstOrDefault();
            ac.Quantity = ac.Quantity + Convert.ToInt32(Q);
            db.SaveChanges();
        }
        public frmResource_POS()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        }

        private void BT_REPORT_Click(object sender, EventArgs e)
        {

        }

        private void comb_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            Resource_ID = Convert.ToInt16(Comb_Name.SelectedValue);
            get_prd_data(Resource_ID);
        }
        frmMainPage fr = new frmMainPage();
        private void frmResource_POS_Load(object sender, EventArgs e)
        {

            txt_Employee.Text = Program.Casheir_Name;
            Enterydate.Text = DateTime.Now.ToShortDateString();
            BT_CANCEL.Enabled = false;
            BT_DEL.Enabled = false;
            BT_PAY.Enabled = false;
            BT_PRINT.Enabled = false;

            LBL_DATE.Text = DateTime.Now.ToShortDateString();
            txt_Quantity.Text = "0";
            txt_Money.Text = "0";
            ListView1.Columns[4].Width = 0;
        }

        private void Comb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Comb_Name.DroppedDown = false;
        }
        public int Bar;

        private void txt_BarCode_KeyDown(object sender, KeyEventArgs e)
        {          
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    
                    int BR = Convert.ToInt16(txt_BarCode.Text);
                    db_model db = new db_model();
                    var Result = db.Resource_Productss.Where
                            (x => x.Barcode == BR &&  x.Resource_Id == Resource_ID)
                            .Select(s => new
                            {Bar = s.Barcode, Nam = s.Name, Money = s.Money, quan = s.Quantity, NOTE = s.Stored_No }).ToList();
                    if (Result.SingleOrDefault() != null)
                    {
                        //TR.Show_Message(Result.SingleOrDefault().Nam);
                        txt_Name.Text = Result.SingleOrDefault().Nam;
                        txt_BarCode.Text = Convert.ToString(Result.SingleOrDefault().Bar);
                        txt_QunInStoke.Text = Convert.ToString(Result.SingleOrDefault().quan);
                        txt_Price.Text = Convert.ToString(Result.SingleOrDefault().Money);
                        txt_Note.Text = Convert.ToString(Result.SingleOrDefault().NOTE);
                    }
                    else
                    {
                        TR.Show_Message("هذا المنتج غير موجود");
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void BT_EXIT_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void txt_Quantity_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                Decimal PRICE = Convert.ToDecimal(txt_Price.Text);
                Decimal QUN = Convert.ToDecimal(txt_Quantity.Text);
               
                Decimal TOTAL_PRICE = (QUN * PRICE);
                txt_Money.Text = TOTAL_PRICE.ToString();
            }
            catch
            {
                return;
            }
        }

        private void txt_Quantity_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txt_Quantity.Text) > Convert.ToInt32(txt_QunInStoke.Text))
                {
                    txt_Quantity.Focus();
                    TR.Show_Message("الكمية المطلوبة غير متوفرة حالياً");
                }
            }
            catch
            {
                return;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            GET_BILLS_ID();
            tabControl1.Enabled = true;
            BT_PAY.Enabled = true;           
            CLEAR_TEXT_BOX(this);
            txt_Quantity.Text = "0";
            txt_Price.Text = "0";
            txt_Employee.Text = Program.Casheir_Name;
            BT_CANCEL.Enabled = true;          
            BT_PRINT.Enabled = true;
            BT_EXIT.Enabled = false;
        }

        private void BT_PRINT_Click(object sender, EventArgs e)
        {
            BT_PAY.Enabled = false;
            BT_PRINT.Enabled = false;
            BT_CANCEL.Enabled = false;
            button1.Enabled = true;
            this.Cursor = Cursors.WaitCursor;
            Resource_Poss TK = new Resource_Poss();
            TK.Parameters["BILLS_NO"].Value = Convert.ToInt32(LBL_BILL_NO.Text);
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;           
            BT_EXIT.Enabled = true;

            ListView1.Items.Clear();
            BT_DEL.Enabled = false;
            tabControl1.Enabled = false;
            CLEAR_TEXT_BOX(this);
        }

        private void BT_CANCEL_Click(object sender, EventArgs e)
        {
            if (ListView1.Items.Count > 0)
            {
                TR.Show_Message("الرجاء مسح جميع المنتجات الموجودة في القائمة");
                BT_CANCEL.Enabled = true;
                BT_PAY.Enabled = true;
                return;

            }

            if (MessageBox.Show("هل أنت متأكد من الغاء الفاتورة ؟", " تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                TR.Show_Message("تم إلغاء الفاتورة");
                BT_PRINT.Enabled = true;
                BT_PAY.Enabled = true;
                BT_DEL.Enabled = true;
                BT_CANCEL.Enabled = true;
                BT_EXIT.Enabled = true;
            }
            else
            {
                BT_PRINT.Enabled = false;
                BT_PAY.Enabled = false;
                BT_DEL.Enabled = false;
                BT_CANCEL.Enabled = false;
                BT_EXIT.Enabled = false;
            }
        }
        string Q; string M = "";

        private void BT_DEL_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListView1.FocusedItem.Selected == false)
                {
                    TR.Show_Message("الرجاء إختيار منتج من القائمة");
                    return;
                }

                else if (MessageBox.Show("  هل تريد حذف هذا المنتج   ", " تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    M = ListView1.SelectedItems[0].SubItems[4].Text;
                    Q = ListView1.SelectedItems[0].SubItems[1].Text;
                    MaxMaize_Quantity(Convert.ToInt32(M));
                    delete_order(Convert.ToInt32(M), Convert.ToInt32(LBL_BILL_NO.Text));
                    this.ListView1.Items.Clear();
                    Fill_ListView(Convert.ToInt32(LBL_BILL_NO.Text));
                    TR.Show_Message("تم حذف المنتج");
                }
            }
            catch
            {
                return;
            }
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            CONTROLS.DropShaddow dr = new CONTROLS.DropShaddow();
            dr.JustNumber(e);
        }

        private void BT_PAY_Click(object sender, EventArgs e)
        {
            if (txt_BarCode.Text == "" || txt_Money.Text == "0" || txt_Quantity.Text == "")
            {
                TR.Show_Message("الرجاء ملء الحقول أولاً");
                return;
            }
            foreach (ListViewItem ITEM in ListView1.Items)
            {
                string MESS = ITEM.SubItems[4].Text.ToString();
                if (txt_BarCode.Text == MESS)
                {
                    TR.Show_Message("تنبيه ! تم إضافة هذا المنتج من قبل  ");
                    return;
                }
            }
            try
            {
                db_model db = new db_model();
                Resource_Pos ac = new Resource_Pos
                {
                    Bill_ID = Convert.ToInt32(LBL_BILL_NO.Text),
                    Barcode = Convert.ToInt32(txt_BarCode.Text),
                    quantity = Convert.ToInt32(txt_Quantity.Text),
                    Resource_Id = Convert.ToInt16(Comb_Name.SelectedValue),
                    Money = Convert.ToDouble(txt_Price.Text),
                    BillDate = Enterydate.Value,
                    Name = txt_Name.Text,
                    Total = Convert.ToDouble(txt_Money.Text)
                };
                db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

                Minimaze_Quantity(Convert.ToInt32(txt_BarCode.Text));
                Fill_ListView(Convert.ToInt32(LBL_BILL_NO.Text));
                SoundPlayer notif = new SoundPlayer(Properties.Resources.notification);
                notif.Play();
                CLEAR_TEXT_BOX(this);
                txt_Quantity.Text = "0";
                txt_Money.Text = "0";
                txt_Price.Text = "0";
                txt_Employee.Text = Program.Casheir_Name;
            }
            catch
            {
                return;
            }
            Enterydate.Text = DateTime.Now.ToShortDateString();
            BT_DEL.Enabled = true;
        }

        private void dgvRouc_pos_Click(object sender, EventArgs e)
        {
            try
            {
                CLEAR_TEXT_BOX(this);
                txt_BarCode.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("كود المنتج"));
                txt_Name.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم المنتج"));
                txt_Price.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("سعر البيع"));
                txt_QunInStoke.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("كمية المخزن"));
                txt_Note.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("رقم التخزين"));
            }
            catch
            {
                return;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

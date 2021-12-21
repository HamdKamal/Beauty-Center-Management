using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SamarPro.CONTROLS;
using Microsoft.VisualBasic;
using DevExpress.XtraReports.UI;
using SamarPro.Reports;

namespace SamarPro.Views
{
    public partial class frmshow_offers : Form
    {
        SqlCommand CMD;
        SqlDataReader RED;
        string SQL;
        double Total_Price = 0;
        BusneisLayer BL = new BusneisLayer();
        CONTROLS.DataAccessLayer DAL = new DataAccessLayer();
        CONTROLS.DropShaddow dr = new CONTROLS.DropShaddow();
        TransationModule TR = new TransationModule();
        void CLEAR_TEXT_BOX(Control CN)
        {

            foreach (Control C in CN.Controls)
                if (C is TextBox)

                    ((TextBox)C).Clear();

                else

                    CLEAR_TEXT_BOX(C);

        }
        int Qun;
        void GET_BILLS_ID()
        {
            DataTable DT = new DataTable();
            DT = BL.Get_Offer_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            LBL_BILL_NO.Text = id.ToString();
        }

        void GET_CODE()
        {
            try
            {
                DAL.open();
                int GT = Convert.ToInt32(LBL_BILL_NO.Text);
                SqlCommand cmd = new SqlCommand("select RES_ID_PRD_ID as Bar from ShowPos WHERE Bill_Id = '" + GT + "' and RES_ID_PRD_ID = '" + prd_id + "'", DAL.Sqlconnection);
                SqlDataReader red = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int ttx = Convert.ToInt16(comb_type.SelectedValue);

                if (red.HasRows)
                {
                    red.Read();
                    if (red["Bar"].ToString() == ttx.ToString())
                    {
                        TR.Show_Message(" تم إضافة هذا المنتج من قبل  ");
                        return;
                    }                    
                }
                red.Close();
                DAL.close();
            }
            catch
            {
                return;
            }
            
            
        }

        void get_total()
        {
                DAL.open();
                int GT = Convert.ToInt32(LBL_BILL_NO.Text);
                SqlCommand cmd = new SqlCommand("select  Sum(Money) as Bar from ShowPos WHERE Bill_Id = '" + GT + "'", DAL.Sqlconnection);
                SqlDataReader red = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                int ttx = Convert.ToInt16(comb_type.SelectedValue);

                if (red.HasRows)
                {
                    red.Read();
                    Total_Price = Convert.ToDouble(red["Bar"]);
                    LBL_BILL_PRICE.Text = Total_Price.ToString();
                }
            red.Close();
            DAL.close();

        }
        void Amal(Boolean SOL)
        {
            bunifuFlatButton2.Enabled = SOL;
            grd.Enabled = SOL;
         

        }
        public frmshow_offers()
        {

            InitializeComponent();
          
        }
        public void product()
        {
            DAL.open();
            SqlCommand cmd = new SqlCommand("select RES_ID_PRD_ID as 'الكود',Shows.ID as 'رقم العرض',dbo.Shows.quan AS 'الكمية', Products.Name as 'الاسم', Shows.Money as 'السعر' FROM Shows INNER JOIN Products ON Shows.RES_ID_PRD_ID=Products.BarCode where Shows.Check_1='Product'", DAL.Sqlconnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grd.DataSource = dt;
            DAL.close();
        }
        public void service()
        {
            DAL.open();
            SqlCommand cmd = new SqlCommand("select RES_ID_PRD_ID as 'الكود',Shows.ID as 'رقم العرض',dbo.Shows.Quan as 'الكمية', Services.Name as 'الاسم', Shows.Money as 'السعر' FROM Shows INNER JOIN Services ON Shows.RES_ID_PRD_ID=Services.ID where Shows.Check_1='Service'", DAL.Sqlconnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grd.DataSource = dt;
            DAL.close();
        
        }
        private void frmshow_offers_Load(object sender, EventArgs e)
        {         
            panel1.Enabled = true;
            Amal(false);
            bunifuCustomLabel17.Text = " : نوع المنتج";
            comb_type.DataSource = BL.get_prd_show();
            comb_type.DisplayMember = "Name";
            comb_type.ValueMember = "RES_ID_PRD_ID";
            LBL_DATE.Text = DateTime.Now.ToShortDateString();
           
            //product();
            bunifuCustomTextbox1.Text = Program.Casheir_Name;
            Sdate.Text = DateTime.Now.ToShortDateString();
            comb_type.Text = "";
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                bunifuiOSSwitch2.Value = false;
                bunifuCustomLabel17 .Text = " : نوع المنتج";
                comb_type.DataSource = BL.get_prd_show();
                comb_type.DisplayMember = "Name";
                comb_type.ValueMember = "RES_ID_PRD_ID";
                grd.Refresh();
                product();
                panel1.Enabled = true;
            }
        }

        private void bunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch2.Value == true)
            {
                bunifuiOSSwitch1.Value = false;
                bunifuCustomLabel17.Text = " : نوع الخدمة";
                comb_type.DataSource = BL.get_service_show();
                comb_type.DisplayMember = "Name";
                comb_type.ValueMember = "RES_ID_PRD_ID";
                grd.Refresh();
                service();
                panel1.Enabled = true;
            }
    }

        private void cardView1_Click(object sender, EventArgs e)
        {
        }

        private void bunifuCustomTextbox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox2.Text == string.Empty || bunifuCustomTextbox9.Text == string.Empty)
            {
                TR.Show_Message("الرجاء إدخال جميع الحقول");
                return;
            }
            db_model db = new db_model();
            ShowPos pos = new ShowPos();
                
                pos.quan = Convert.ToInt16(bunifuCustomTextbox2.Text);
                pos.RES_ID_PRD_ID = Convert.ToInt16(comb_type.SelectedValue);
                double total = Convert.ToDouble(bunifuCustomTextbox9.Text) * Convert.ToDouble(bunifuCustomTextbox2.Text);
                pos.Money = total;
                pos.Emp_Name = bunifuCustomTextbox1.Text;
                pos.Entery_date = Sdate.Value;
                pos.Bill_Id = Convert.ToInt32(LBL_BILL_NO.Text);
            db.Entry(pos).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();           
           

            int quan = Convert.ToInt32(bunifuCustomTextbox2.Text);
            DAL.open();
            SqlCommand cmd = new SqlCommand("update Shows set quan=quan-'"+quan+"' where ID='" + num + "'", DAL.Sqlconnection);
            cmd.ExecuteNonQuery();
            DAL.close();
                      
            bunifuCustomTextbox1.Text = Program.Casheir_Name;
            Sdate.Text = DateTime.Now.ToShortDateString();
            TR.EnterLog(": تم إضافة فاتورة عرض  بإسم " + comb_type.Text);
           
            get_total();
            CLEAR_TEXT_BOX(this);
            if (bunifuiOSSwitch1.Value == true)
            {
                product();

            }
            else
            {
                service();
            }
            panel1.Enabled = true;
            Amal(true);           
            TR.Show_Message("تم إضافة المنتج إلى سلة المشتريات ");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            panel1.Enabled = true;
            bunifuCustomTextbox1.Text = Program.Casheir_Name;
            bunifuFlatButton1.Enabled = false;
            bunifuFlatButton2.Enabled = true;
            bunifuFlatButton4.Enabled = true;
            Sdate.Text = DateTime.Now.ToShortDateString();
            Amal(true);
            GET_BILLS_ID();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardView1_Click_1(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string myva = Interaction.InputBox("ادخل رقم الفاتورة", "استرجاع عرض");              
                    int d = Convert.ToInt32(myva);

                    DAL.open();
                    SqlCommand cmd = new SqlCommand("update Shows set Shows.quan=Shows.quan+ShowPos.quan from Shows INNER JOIN ShowPos ON Shows.RES_ID_PRD_ID=ShowPos.RES_ID_PRD_ID where Shows.RES_ID_PRD_ID='" + comb_type.SelectedValue + "'and ShowPos.Bill_Id='" + myva + "' ", DAL.Sqlconnection);
                    cmd.ExecuteNonQuery();
                    DAL.close();
                    db_model db = new db_model();
                    ShowPos ac = (from c in db.ShowPos where c.Bill_Id == d select c).FirstOrDefault();
                    db.ShowPos.Where(a => a.Bill_Id == d).Select(s => s).FirstOrDefault();
                    db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;

                    db.SaveChanges();
                    TR.Show_Message("تم حذف الفاتورة");
                    bunifuCustomTextbox1.Text = Program.Casheir_Name;
                    TR.EnterLog(": تم إسترجاع فاتورة عرض  برقم " + d);
                
            }
            catch
            {
                return;
            }   
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_Leave(object sender, EventArgs e)
        {
            GET_CODE();
            try
            {
                if (Convert.ToInt32(bunifuCustomTextbox2.Text) > Convert.ToInt32(Qun))
                {
                    bunifuCustomTextbox2.Focus();
                    TR.Show_Message("انتبه ! الكمية المطلوبه تعدت الكمية المتاحة للعرض");
                    LBL_Info.Visible = true;
                    LBL_Info.Text = "الكمية المتاحة للعرض " + Qun;
                    return;                   
                }
            }
            catch
            {
                return;

            }
        }

        private void bunifuCustomTextbox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageDown)
            {
                LBL_Info.Visible = false;
            }
        }

        private void comb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String ID = Convert.ToString(comb_type.SelectedValue);
                label1.Text = ID;
                SQL = "SELECT QUAN,Money FROM Shows WHERE ID = '" + label1.Text + "'";
                CMD = new SqlCommand(SQL, DAL.Sqlconnection);
                DAL.close();
                DAL.open();
                RED = CMD.ExecuteReader();           
             
                while (RED.Read())
                {
                    bunifuCustomTextbox9.Text = RED[1].ToString();
                    Qun =Convert.ToInt16(RED[0]);
                }
                DAL.close();
            }
             
            catch
            {
                return;
            }
        }
        private void grd_Click(object sender, EventArgs e)
        {

        }
        int num,prd_id;
        private void cardView1_Click_2(object sender, EventArgs e)
        {
            try
            {
                prd_id = Convert.ToInt32(cardView1.GetFocusedRowCellValue("الكود"));
                num = Convert.ToInt32(cardView1.GetFocusedRowCellValue("رقم العرض"));
                comb_type.Text = Convert.ToString(cardView1.GetFocusedRowCellValue("الاسم"));
                bunifuCustomTextbox9.Text = Convert.ToString(cardView1.GetFocusedRowCellValue("السعر"));
                Qun=Convert.ToInt32(cardView1.GetFocusedRowCellValue("الكمية"));
            }
            catch
            {
                return;
            }
            GET_CODE();
        }

        private void bunifuCustomTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
            LBL_Info.Visible = false;
        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Show_Invoice TK = new Show_Invoice();
            TK.Parameters["BILLS_NO"].Value = Convert.ToInt32(LBL_BILL_NO.Text);
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;

            LBL_BILL_NO.Text = "0";
            LBL_BILL_PRICE.Text = "0";
            bunifuFlatButton1.Enabled = true;
            bunifuFlatButton2.Enabled = false;
            bunifuFlatButton4.Enabled = false;
        }

        private void comb_type_Leave(object sender, EventArgs e)
        {
            GET_CODE();
        }
    }
}

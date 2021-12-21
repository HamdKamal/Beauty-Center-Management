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
using System.Data.Entity;
using Microsoft.VisualBasic;
using SamarPro.Reports;
using DevExpress.XtraReports.UI;

namespace SamarPro
{
    public partial class frmTutorialReg : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();
        TransationModule TR = new TransationModule();
       //public void get()
       // {
       //     DAL.open();
       //     SqlCommand cmd = new SqlCommand("select Name from Tutorials", DAL.Sqlconnection);
       //     SqlDataReader reaader= cmd.ExecuteReader();
       //     DataTable dt = new DataTable();
       //     dt.Columns.Add("Name", typeof(String));
       //     dt.Load(reaader);         
       //     comboBox1.DisplayMember ="Name";
       //     comboBox1.DataSource = dt;
       //     DAL.close();
       // }
        public void price()
        {
        }
        void CLEAR_TEXT_BOX(Control CN)
        {
            foreach (Control C in CN.Controls)
                if (C is TextBox)

                    ((TextBox)C).Clear();
                else
                    CLEAR_TEXT_BOX(C);
        }
        void Amal(Boolean SOL)
        {
            btn_del.Enabled = SOL;
            btn_edit.Enabled = SOL;
            btn_save.Enabled = SOL;
        }
        public frmTutorialReg()
        {
            InitializeComponent();
       
      
            sqlDataSource1.Fill();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //get();
            comboBox1.Text = "";
            bunifuCustomTextbox1.Text = "";
            groupBox1.Enabled = false;
            Amal(false);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            groupBox1.Enabled = true;
            btn_save.Enabled = true;
            btn_new.Enabled = false;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
            btn_Print.Enabled = false;

            comboBox1.Enabled = true;
            bunifuCustomTextbox1.Enabled = false;
            bunifuCustomTextbox3.Enabled = true;
            bunifuCustomTextbox2.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox2.Text == string.Empty || txtAcc.Text == string.Empty || bunifuCustomTextbox3.Text == string.Empty)
            {
                MessageBox.Show("الرجاء إدخال جميع الحقول");
                return;
            }
             db_model db = new db_model();
            TutorialRegs ac = new TutorialRegs
            {
                Name = txtAcc.Text,
                Tutorial_Name = comboBox1.Text,
                Phone_Number = bunifuCustomTextbox5.Text,
                Another_Phone = bunifuCustomTextbox6.Text,
                E_Date = DateTime.Today.Date,
                Price = Convert.ToDouble(bunifuCustomTextbox1.Text),
                Paid = Convert.ToDouble(bunifuCustomTextbox3.Text),
                Withdrow = Convert.ToDouble(bunifuCustomTextbox2.Text),
                Note = bunifuCustomTextbox4.Text,
                Tutorial_ID = Convert.ToInt32(comboBox1.SelectedValue)
            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            sqlDataSource1.Fill();
            TR.Show_Message("تم التسجيل في الكورس");
            comboBox1.Text = "";
            groupBox1.Enabled = false;
            Amal(false);
            btn_save.Enabled = false;
            btn_new.Enabled = true;
            CLEAR_TEXT_BOX(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DAL.Sqlconnection.State == 0)
            {
                DAL.open();
            }
            SqlCommand cmd = new SqlCommand("select price from Tutorials where Name=N'" + comboBox1.Text + "'", DAL.Sqlconnection);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                bunifuCustomTextbox1.Text = dr["price"].ToString();

            }
            DAL.close();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }
        string D1;
        private void dgvShow_Click(object sender, EventArgs e)
        {
            btn_del.Enabled = true;
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            btn_Print.Enabled = true;
            groupBox1.Enabled = true;
            comboBox1.Enabled = false;
            bunifuCustomTextbox1.Enabled = false;
            bunifuCustomTextbox3.Enabled = false;
            bunifuCustomTextbox2.Enabled = false;
            try
            {
                Name = Convert.ToString(gridView2.GetFocusedRowCellValue("الرقم"));
                comboBox1.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("اسم الكورس"));
                bunifuCustomTextbox5.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("رقم الهاتف"));
                bunifuCustomTextbox6.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("التلفون"));
                txtAcc.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("اسم العميل"));
                bunifuCustomTextbox1.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("السعر"));
                bunifuCustomTextbox3.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("المدفوع"));
                bunifuCustomTextbox2.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("المتبقي"));
                bunifuCustomTextbox4.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("ملاحظة"));            
                D1 = Convert.ToString(gridView2.GetFocusedRowCellValue("التاريخ"));
                g = Convert.ToString(gridView2.GetFocusedRowCellValue("المتبقي"));
                COU_ID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("رقم الكورس"));
            }
            catch
            {
                return;
            }
        }
        int COU_ID;
        private void btn_edit_Click(object sender, EventArgs e)
        {
            db_model db = new db_model();
            TutorialRegs ac = new TutorialRegs
            {
                ID = Convert.ToInt16(Name),
                Name = txtAcc.Text,
                Tutorial_Name = comboBox1.Text,
                Phone_Number =bunifuCustomTextbox5.Text,
                Another_Phone = bunifuCustomTextbox6.Text,
                E_Date =Convert.ToDateTime(D1),
                Price = Convert.ToDouble(bunifuCustomTextbox1.Text),
                Paid = Convert.ToDouble(bunifuCustomTextbox3.Text),
                Withdrow = Convert.ToDouble(bunifuCustomTextbox2.Text),
                Note = bunifuCustomTextbox4.Text,
                Tutorial_ID = COU_ID
            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();           
            TR.Show_Message("تم  تعديل بيانات الكورس");
            sqlDataSource1.Fill();
            comboBox1.Text = "";
            groupBox1.Enabled = false;
            Amal(false);
            btn_save.Enabled = false;
            btn_new.Enabled = true;
            CLEAR_TEXT_BOX(this);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف السجل المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int X = Convert.ToInt16(Name);
                db_model db = new db_model();
                TutorialRegs ac = (from c in db.TutorialRegs where c.ID == X select c).FirstOrDefault();
                db.TutorialRegs.Where(a => a.ID == X).Select(s => s).FirstOrDefault();
                db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
                TR.Show_Message("تم حذف بيانات الكورس");
                sqlDataSource1.Fill();
                TR.EnterLog(": تم حذف بيانات كورس بإسم " + comboBox1.Text);
            }
            else
            {
                TR.Show_Message("تم إلغاء عملية الحذف");
            }
            CLEAR_TEXT_BOX(this);
        }
        private void bunifuCustomTextbox3_TextChanged(object sender, EventArgs e)
        {          
        }
        private void bunifuCustomTextbox3_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(bunifuCustomTextbox1.Text);
                double b = Convert.ToDouble(bunifuCustomTextbox3.Text);
                if (b > a)
                {
                    TR.Show_Message("عذراً : المبلغ المدفوع أكبر من المبلغ الكلي");
                  
                }
                else
                {
                    double sum = a - b;
                    bunifuCustomTextbox2.Text = sum.ToString();
                }
            }
            catch 
            {
                return;               
            }          
        }

        private void bunifuCustomTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {       
        }

        private void bunifuCustomTextbox3_Leave(object sender, EventArgs e)
        {
           
        }

        private void bunifuCustomTextbox3_Layout(object sender, LayoutEventArgs e)
        {
        
        }

        private void bunifuCustomTextbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            DropShaddow dr = new DropShaddow();
            dr.JustNumber(e);
        }

        private void txtAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            DropShaddow dr = new DropShaddow();
            dr.JustString(e);
        }

        private void bunifuCustomTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            DropShaddow dr = new DropShaddow();
            dr.JustString(e);
        }

        private void bunifuGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        string myva, g;
        double d;
        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Course_Invoice TK = new Course_Invoice();
            TK.Parameters["Course_Code"].Value = Convert.ToInt16(Name);
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;
            TR.EnterLog(": تم إضافة فاتورة كورس برقم  " + Convert.ToInt16(Name));
            btn_Print.Enabled = false;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {   
            try
            {
                myva = Interaction.InputBox("ادخل المبلغ المدفوع ", " دفعة جديدة");
                d = Convert.ToInt32(myva);
                bunifuCustomTextbox2.Text = g;
                if (d > Convert.ToDouble(g))
                {
                    TR.Show_Message("عذراً :  المبلغ المراد دفعه أكبر من المتبقي");
                    return;
                }
                if (bunifuCustomTextbox3.Text == bunifuCustomTextbox1.Text)
                {
                    TR.Show_Message("عذراً :  تم سداد قيمة الكورس");
                    return;
                }
                if (bunifuCustomTextbox2.Text == "0")
                {
                    TR.Show_Message("عذراً : تم سداد قيمة الكورس");
                    return;
                }
                DAL.open();
                SqlCommand cmd = new SqlCommand("update TutorialRegs set TutorialRegs.Paid =TutorialRegs.Paid + '"+d+ "', TutorialRegs.Withdrow = TutorialRegs.Withdrow - '"+d+ "' where TutorialRegs.ID = '"+ Convert.ToInt32(Name) +"' ", DAL.Sqlconnection);
                cmd.ExecuteNonQuery();
                DAL.close();
                CLEAR_TEXT_BOX(this);
                sqlDataSource1.Fill();
            }
            catch
            {
                return;
            }
        }
    }
}


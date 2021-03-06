using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SamarPro.CONTROLS;
using SamarPro;

namespace SamarPro.Views
{
    public partial class frmTutotial : Form
    {
        TransationModule TR = new TransationModule();  
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
        public frmTutotial()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            groupBox1.Enabled = true;
            btn_save.Enabled = true;
            btn_new.Enabled = false;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            Amal(false);
        }

        private void dgvShow_Click(object sender, EventArgs e)
        {
            btn_del.Enabled = true;
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            groupBox1.Enabled = true;
            try
            {
                Cou_ID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("رقم الكورس"));
                txtName.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم الكورس"));
                price.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("السعر"));
                bunifuDatepicker1.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("تاريخ البداية"));
                bunifuDatepicker2.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("تاريخ النهاية"));
            }
            catch
            {
                return;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // this code for save data in database
            if (txtName.Text == string.Empty || price.Text == string.Empty)
            {
               TR.Show_Message("الرجاء إدخال جميع الحقول");
                return;
            }
            db_model db = new db_model();
            Tutorials ac = new Tutorials
            {
                Name = txtName.Text,
                price = Convert.ToInt32(price.Text),
                Start_Date = bunifuDatepicker1.Value,
                End_Date = bunifuDatepicker2.Value

            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
           sqlDataSource1.Fill();
            TR.Show_Message("تم إضافة كورس جديد");
            groupBox1.Enabled = false;
            Amal(false);
            btn_save.Enabled = false;
            btn_new.Enabled = true;
            CLEAR_TEXT_BOX(this);
        
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int Cou_ID;
        private void btn_edit_Click(object sender, EventArgs e)
        {
            db_model db = new db_model();
            Tutorials ac = new Tutorials
            {
                ID = Cou_ID,
                Name = txtName.Text,
                price = Convert.ToInt32(price.Text),
                Start_Date = bunifuDatepicker1.Value,
                End_Date = bunifuDatepicker2.Value

            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            sqlDataSource1.Fill();
            TR.Show_Message("تم  تعديل بيانات الكورس");
            groupBox1.Enabled = false;
            Amal(false);
            btn_save.Enabled = false;
            btn_new.Enabled = true;
            CLEAR_TEXT_BOX(this);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف الكورس المحدد ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db_model db = new db_model();
                Tutorials ac = (from c in db.Tutorialss where c.ID == Cou_ID select c).FirstOrDefault();
                db.Tutorialss.Where(a => a.ID == Cou_ID).Select(s => s).FirstOrDefault();
                db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
                TR.Show_Message("تم حذف الكورس");
                sqlDataSource1.Fill();
             
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف");
            }
            CLEAR_TEXT_BOX(this);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            DropShaddow dr = new DropShaddow();
            dr.JustString(e);
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            DropShaddow dr = new DropShaddow();
            dr.JustNumber(e);
        }
    }
}

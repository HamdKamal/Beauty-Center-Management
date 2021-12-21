﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamarPro.Views
{
    public partial class frmSupplaier : Form
    {
        int Supplaier_ID; // for any ID Of Each form 
        TransationModule TR = new TransationModule();
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
        CONTROLS.DropShaddow dr = new CONTROLS.DropShaddow();
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
        public frmSupplaier()
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

        private void frmSupplaier_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            Amal(false);
        }

        private void dgvSupplaier_Click(object sender, EventArgs e)
        {
            btn_del.Enabled = true;
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            groupBox1.Enabled = true;
            try
            {
                Supplaier_ID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("رقم المسوق"));
                txtName.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم المسوق"));
                txtNote.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("ملاحظة"));
                txtAdress.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("العنوان"));
                txtPhone.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("رقم الهاتف"));
            }
            catch
            {
                return;
            }
                
                
            }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // this code for save data in database
            if (txtName.Text == string.Empty || txtAdress.Text == string.Empty)
            {
                TR.Show_Message("الرجاء إدخال جميع الحقول");
                return;
            }
            db_model db = new db_model();
            Supplayier ac = new Supplayier
            {
                Note = txtNote.Text,
                Name = txtName.Text,
                Adress = txtAdress.Text,
                Phone= txtPhone.Text

            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            sqlDataSource1.Fill();
            TR.Show_Message("تم إضافة مسوق");
            groupBox1.Enabled = false;
            Amal(false);
            btn_save.Enabled = false;
            btn_new.Enabled = true;
            CLEAR_TEXT_BOX(this);
            TR.EnterLog(": تم إضافة بيانات مسوق بإسم " + txtName.Text);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف بيانات المسوق المحدد ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db_model db = new db_model();
                Supplayier ac = (from c in db.Supplayiers where c.ID == Supplaier_ID select c).FirstOrDefault();
                db.Supplayiers.Where(a => a.ID == Supplaier_ID).Select(s => s).FirstOrDefault();
                db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
                TR.Show_Message("تم حذف بيانات المسوق ");
                sqlDataSource1.Fill();
                TR.EnterLog(": تم حذف بيانات المسوق برقم " + Supplaier_ID);
            }
            else
            {
                TR.Show_Message("تم إلغاء عملية الحذف");
            }
            CLEAR_TEXT_BOX(this);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            db_model db = new db_model();
            Supplayier ac = new Supplayier
            {
                ID = Supplaier_ID,
                Note = txtNote.Text,
                Name = txtName.Text,
                Adress = txtAdress.Text,
                Phone = txtPhone.Text

            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            TR.Show_Message("تم تعديل بيانات مسوق");
            sqlDataSource1.Fill();
            groupBox1.Enabled = false;
            Amal(false);
            btn_edit.Enabled = false;
            btn_new.Enabled = true;
            CLEAR_TEXT_BOX(this);
            TR.EnterLog(": تم تعديل بيانات مسوق برقم " + Supplaier_ID);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustString(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }
    }
}
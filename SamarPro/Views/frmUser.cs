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
    public partial class frmUser : Form
    {
        int userID; // for any ID Of Each form 
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
        void GETUser_ID() // this function genrate Id by Increase 1 
        {
            DataTable DT = new DataTable();
            DT = BL.GETUser_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            userID = id;
        }
      
        public void COM_ID()  // fill combobox from data base
        {
            comb_emp.DataSource = BL.get_username();
            comb_emp.DisplayMember = "Name";
            comb_emp.ValueMember = "ID";

        }
        public frmUser()
        {
            InitializeComponent();
           
            COM_ID();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
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
            dr.DesibleCombo(groupBox1, true);
            GETUser_ID();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            // this code for save data in database
            if (txt_Name.Text == string.Empty || txt_pass.Text == string.Empty)
                {
                TR.Show_Message("الرجاء إدخال جميع الحقول");
                return;
                }

            if (txt_pass.Text != txt_Confiq.Text)
            {
                TR.Show_Message("الرجاء تأكيد كامة المرور");
                return;
            }
            db_model db = new db_model();
            TBLuser ac = new TBLuser
            {
                //ID = userID,
                Name = txt_Name.Text,
                Em_ID = Convert.ToInt16(comb_emp.SelectedValue),
                Type = com_type.Text,
                PassWord = txt_pass.Text,
            };

            db.Entry(ac).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            TR.Show_Message("تم إضافة مستخدم");
            sqlDataSource1.Fill();
            groupBox1.Enabled = false;
            Amal(false);
            btn_save.Enabled = false;
            btn_new.Enabled = true;          
       
            TR.EnterLog(": تم إضافة بيانات مستخدم بإسم " + txt_Name.Text);
            CLEAR_TEXT_BOX(this);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            db_model db = new db_model();
            TBLuser ac = new TBLuser
            {
                ID = userID,
                Name = txt_Name.Text,
                Em_ID = Convert.ToInt16(comb_emp.SelectedValue),
                Type = com_type.Text,
                PassWord = txt_pass.Text,
            };

            db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            TR.Show_Message("تم تعديل بيانات مستخدم");
            sqlDataSource1.Fill();
            groupBox1.Enabled = false;
            Amal(false);
            btn_edit.Enabled = false;
            btn_new.Enabled = true;
            
            TR.EnterLog(": تم تعديل بيانات مستخدم برقم " + userID);
            CLEAR_TEXT_BOX(this);
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف بيانات المستخدم المحدد!", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db_model db = new db_model();
                TBLuser ac = (from c in db.TBLusers where c.ID == userID select c).FirstOrDefault();
                db.TBLusers.Where(a => a.ID == userID ).Select(s => s).FirstOrDefault();
                db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
                TR.Show_Message("تم حذف بيانات المستخدم ");
                sqlDataSource1.Fill();
                TR.EnterLog(": تم حذف بيانات مستخدم برقم " + userID);
            }
            else
            {
                TR.Show_Message("تم إلغاء عملية الحذف");
            }
            CLEAR_TEXT_BOX(this);
        }

        private void dgvUser_Click(object sender, EventArgs e)
        {
            btn_del.Enabled = true;
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            groupBox1.Enabled = true;
            dr.DesibleCombo(groupBox1,false);
           try
            {
                userID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("رقم المستخدم"));
                txt_Name.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم المستخدم"));
                txt_pass.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("كلمة المرور"));
                comb_emp.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم الموظف"));
                com_type.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("نوع المستخدم"));
                txt_Confiq.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("كلمة المرور"));
               // MessageBox.Show(userID.ToString());
            }
            catch
            {
                return;
            }
            
        }
    }
}
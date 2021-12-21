﻿using SamarPro.CONTROLS;
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

namespace SamarPro.Views
{
    public partial class FRM_RessourceProduct : Form
    {
        TransationModule TR = new TransationModule();
        DropShaddow dr = new DropShaddow();
        public int Product_ID,F_quan; // for any ID Of Each form 
        CONTROLS.DataAccessLayer DAL = new CONTROLS.DataAccessLayer();
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
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
        void GET_CODE()
        {
            DAL.open();
            SqlCommand cmd = new SqlCommand("select Barcode as Bar from Resource_Products WHERE Barcode = '" + txt_Code.Text + "'", DAL.Sqlconnection);
            SqlDataReader red = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            string ttx = (txt_Code.Text);

            if (red.HasRows)
            {
                red.Read();
                if (red["Bar"].ToString() == ttx)
                {
                    TR.Show_Message("تنبيه ! تم إضافة هذا المنتج من قبل  ");
                    txt_Code.Text = "";
                    txt_Code.Focus();
                }
                else
                {
                    txtName.Focus();
                }
            }
            red.Close();
            DAL.close();
        }
        public FRM_RessourceProduct()
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

        private void FRM_RessourceProduct_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            txt_No.Text = "0";
            Amal(false);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            check_1.Checked = false;
            groupBox1.Enabled = true;
            txtQuan.Enabled = true;
            txtQuan.ReadOnly = false;
            btn_save.Enabled = true;
            btn_new.Enabled = false;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
            txt_No.Text = "0";
            ExpiredDate.Text = DateTime.Now.ToShortDateString();
            EnteryDate.Text = DateTime.Now.ToShortDateString();
        }
        private void check_1_CheckedChanged(object sender, EventArgs e)
        {
            if(check_1.Checked == true)
            {
                txtName.Enabled = false;
                txt_No.Enabled = true;
                txtName.Text = "بدون";
            }
            else
            {
                txtName.Enabled = true;
                txt_No.Enabled = false;
            }
            
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            // this code for save data in database
            if (txt_Code.Text == string.Empty || txtQuan.Text == string.Empty)
            {
                TR.Show_Message("الرجاء إدخال جميع الحقول");
                return;
            }
            try
            {
                db_model db = new db_model();
                Resource_Products ac = new Resource_Products
                {
                    Barcode = Convert.ToInt16(txt_Code.Text),
                    Name = txtName.Text,
                    Stored_No = Convert.ToInt16(txt_No.Text),
                    Resource_Id = Convert.ToInt16(com_Name.SelectedValue),
                    Quantity = Convert.ToInt16(txtQuan.Text),
                    Unit_Size = Convert.ToInt16(txt_Unit.Text),
                    Money = Convert.ToDouble(txt_Money.Text),
                    Unit_type = com_unit.Text,
                    ExpiredDate = ExpiredDate.Value,
                    EnteryDate = EnteryDate.Value,
                    Note = txtNote.Text,
                    First_Quan = Convert.ToInt16(txtQuan.Text)
                };
                db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                TR.Show_Message("تم إضافة منتج");
                sqlDataSource1.Fill();
                groupBox1.Enabled = false;
                Amal(false);
                btn_save.Enabled = false;
                btn_new.Enabled = true;
                TR.EnterLog(": تم إضافة منتج برقم " + txt_Code.Text);
                CLEAR_TEXT_BOX(this);
            }
            catch
            {
                return;
            }
        }
        private void txt_Code_Leave(object sender, EventArgs e)
        {
            GET_CODE();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                db_model db = new db_model();
                Resource_Products ac = new Resource_Products
                {
                    ID = Product_ID,
                    Barcode = Convert.ToInt16(txt_Code.Text),
                    Name = txtName.Text,
                    Stored_No = Convert.ToInt16(txt_No.Text),
                    Resource_Id = Convert.ToInt16(com_Name.SelectedValue),
                    Quantity = Convert.ToInt16(txtQuan.Text),
                    Unit_Size = Convert.ToInt16(txt_Unit.Text),
                    Money = Convert.ToDouble(txt_Money.Text),
                    Unit_type = com_unit.Text,
                    ExpiredDate = ExpiredDate.Value,
                    EnteryDate = EnteryDate.Value,
                    Note = txtNote.Text,
                    First_Quan =Convert.ToInt16(F_quan)
                };
                db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                TR.Show_Message("تم تعديل منتج");
                sqlDataSource1.Fill();
                groupBox1.Enabled = false;
                Amal(false);
                btn_save.Enabled = false;
                btn_new.Enabled = true;
                TR.EnterLog(": تم تعديل منتج برقم " + txt_Code.Text);
                CLEAR_TEXT_BOX(this);
            }
            catch
            {
                return;
            }
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتج المحدد ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db_model db = new db_model();
                Resource_Products ac = (from c in db.Resource_Productss where c.ID == Product_ID select c).FirstOrDefault();
                db.Resource_Productss.Where(a => a.ID == Product_ID).Select(s => s).FirstOrDefault();
                db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                TR.Show_Message("تم حذف المنتج");
                sqlDataSource1.Fill();
                TR.EnterLog(": تم حذف بيانات منتج برقم " + txt_Code.Text);
            }
            else
            {
                TR.Show_Message("تم إلغاء عملية الحذف");
            }
            CLEAR_TEXT_BOX(this);
        }
        string D1, D3;
        private void dgvShow_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            btn_del.Enabled = true;
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            groupBox1.Enabled = true;
            try
            {
                if(Convert.ToString(gridView2.GetFocusedRowCellValue("إسم المنتج")) == "بدون")
                {
                    txtName.Enabled = false;
                    check_1.Checked = true;
                }
                Product_ID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("المعرف"));
                txt_Code.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("كود المنتج"));
                txtName.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم المنتج"));
                txtQuan.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("الكمية"));
                txtNote.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("ملاحظة"));
                txt_Money.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("سعر المنتج"));
                txt_No.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("رقم التخزين"));
                txt_Unit.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("حجم العبوة"));
                com_Name.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم المورد"));
                com_unit.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("مقياس العبوة"));
                F_quan = Convert.ToInt16(gridView2.GetFocusedRowCellValue("الكمية الأولية"));


                D1 = Convert.ToString(gridView2.GetFocusedRowCellValue("Entery Date"));
                EnteryDate.Value = Convert.ToDateTime(D1);
                D3 = Convert.ToString(gridView2.GetFocusedRowCellValue("Expired Date"));
                ExpiredDate.Value = Convert.ToDateTime(D3);
            }
            catch
            {
                return;
            }
        }
    }
}


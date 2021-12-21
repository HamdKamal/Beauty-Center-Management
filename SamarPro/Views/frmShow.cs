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
    public partial class frmShow : Form
    {
        int Show_ID; // for any ID Of Each form 
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
        void Minimaze_Quantity(int BarCode)
        {
            db_model db = new db_model();
            Product ac = (from c in db.Products where c.BarCode == BarCode select c).FirstOrDefault();
            db.Products.Where(s => s.BarCode == BarCode).Select(s => s).FirstOrDefault();
            ac.Quntity = ac.Quntity - Convert.ToInt32(txtQuan.Text);
            db.SaveChanges();
        }
        void MaxMaize_Quantity(int BarCode)
        {
            db_model db = new db_model();
            Product ac = (from c in db.Products where c.BarCode == BarCode select c).FirstOrDefault();
            db.Products.Where(s => s.BarCode == BarCode).Select(s => s).FirstOrDefault();
            ac.Quntity = ac.Quntity + Convert.ToInt32(txtQuan.Text);
            db.SaveChanges();
        }
        void MaxMaize_ServiceQuantity(int BarCode)
        {
            db_model db = new db_model();
            var result  = (from c in db.Services where c.ID == BarCode select c).FirstOrDefault();
            db.Services.Where(s => s.ID == BarCode).Select(s => s.PRD_ID).FirstOrDefault();
            int PrdId = result.PRD_ID;

            Product ac = (from c in db.Products where c.ID == PrdId select c).FirstOrDefault();
            db.Products.Where(s => s.ID == PrdId ).Select(s => s).FirstOrDefault();
            ac.Quntity = ac.Quntity - Convert.ToInt32(txtQuan.Text);
            db.SaveChanges();
        }

        void Delete_ServiceQuantity(int BarCode)
        {
            db_model db = new db_model();
            var result = (from c in db.Services where c.ID == BarCode select c).FirstOrDefault();
            db.Services.Where(s => s.ID == BarCode).Select(s => s.PRD_ID).FirstOrDefault();
            int PrdId = result.PRD_ID;

            Product ac = (from c in db.Products where c.ID == PrdId select c).FirstOrDefault();
            db.Products.Where(s => s.ID == PrdId).Select(s => s).FirstOrDefault();
            ac.Quntity = ac.Quntity + Convert.ToInt32(txtQuan.Text);
            db.SaveChanges();
        }
        public frmShow()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker3_onValueChanged(object sender, EventArgs e)
        {

        }
        string JK;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            JK = "Product";
            lbl_type.Text = " : نوع المنتج";
            comb_type.DataSource = BL.getProduct_Name();
            comb_type.DisplayMember = "Name";
            comb_type.ValueMember = "BarCode";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            JK = "Service";
            lbl_type.Text = " : نوع الخدمة";
            comb_type.DataSource = BL.getServise_Name();
            comb_type.DisplayMember = "Name";
            comb_type.ValueMember = "ID";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            pnl_1.Enabled = true;
            btn_save.Enabled = true;
            btn_new.Enabled = false;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
            Sdate.Text = DateTime.Now.ToShortDateString();
            Edate.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // this code for save data in database
            if (txtQuan.Text == string.Empty || txtMoney.Text == string.Empty)
            {
                TR.Show_Message("الرجاء إدخال جميع الحقول");
                return;
            }
            try
            {
                db_model db = new db_model();
                Show ac = new Show
                {
                    quan = Convert.ToInt16(txtQuan.Text),
                    Name = comb_type.Text,
                    RES_ID_PRD_ID = Convert.ToInt16(comb_type.SelectedValue),
                    Money = Convert.ToDouble(txtMoney.Text),
                    Note = txtNote.Text,
                    Sdate = Sdate.Value,
                    Edate = Edate.Value,
                    Check_1 = JK
                };
                db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                sqlDataSource1.Fill();
                TR.Show_Message("تم إضاف عرض");
                if (radioButton2.Checked == true)
                {
                    MaxMaize_ServiceQuantity(Convert.ToInt16(comb_type.SelectedValue));
                }
                else
                {
                    Minimaze_Quantity(Convert.ToInt16(comb_type.SelectedValue));
                }
                pnl_1.Enabled = false;
                Amal(false);
                btn_save.Enabled = false;
                btn_new.Enabled = true;
                CLEAR_TEXT_BOX(this);
                TR.EnterLog(": تم إضاف عرض  بإسم " + txtNote.Text);
            }
            catch
            {
                return;
            }
            
        }

        private void frmShow_Load(object sender, EventArgs e)
        {
            pnl_1.Enabled = false;
            Amal(false);

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        string x;
        private void dgvShow_Click(object sender, EventArgs e)
        {
            btn_del.Enabled = true;
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            pnl_1.Enabled = true;
            try
            {
                Show_ID = Convert.ToInt32(gridView2.GetFocusedRowCellValue("الرقم"));
                txtMoney.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("السعر"));
                txtNote.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("ملاحظة"));
                txtQuan.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("الكمية"));
               
                string  d = Convert.ToString(gridView2.GetFocusedRowCellValue("بداية"));
                Sdate.Value = Convert.ToDateTime(d);
                string d1 = Convert.ToString(gridView2.GetFocusedRowCellValue("نهاية"));
                Edate.Value = Convert.ToDateTime(d1);

                JK = Convert.ToString(gridView2.GetFocusedRowCellValue("JCK"));
                if(JK == "Product")
                {
                    radioButton1.Checked = true;
                    lbl_type.Text = ": نوع المنتج";
                    comb_type.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم المنتج / الخدمة"));
                    x = Convert.ToString(gridView2.GetFocusedRowCellValue("المنتج / الخدمة"));
                    using (var context = new db_model())
                    {
                        var query = from st in context.Products
                                    where st.BarCode ==Convert.ToInt32(x)
                                    select comb_type.Text == st.Name;                     
                    }
                }
                else
                {
                    radioButton2.Checked = true;
                    lbl_type.Text = ": نوع الخدمة";
                    comb_type.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم المنتج / الخدمة"));
                    x = Convert.ToString(gridView2.GetFocusedRowCellValue("المنتج / الخدمة"));
                    using (var context = new db_model())
                    {
                        var query = from st in context.Services
                                    where st.Name == x.ToString()
                                    select comb_type.Text == st.Name;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العرض المحدد ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db_model db = new db_model();
                Show ac = (from c in db.Shows where c.ID == Show_ID select c).FirstOrDefault();
                db.Shows.Where(a => a.ID == Show_ID).Select(s => s).FirstOrDefault();
                db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
                TR.Show_Message("تم حذف العرض ");
                sqlDataSource1.Fill();
                if(radioButton1.Checked == true)
                {
                    MaxMaize_Quantity(Convert.ToInt16(comb_type.SelectedValue));
                }
                else
                {
                    Delete_ServiceQuantity(Convert.ToInt16(comb_type.SelectedValue));
                }
                TR.EnterLog(": تم حذف عرض  برقم " + Show_ID);
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
            Show ac = new Show
            {
                ID = Show_ID,
                Name = comb_type.Text,
                quan = Convert.ToInt16(txtQuan.Text),
                RES_ID_PRD_ID = Convert.ToInt16(comb_type.SelectedValue),
                Money = Convert.ToDouble(txtMoney.Text),
                Note = txtNote.Text,
                Sdate = Sdate.Value,
                Edate = Edate.Value,
                Check_1 = JK
            };

            db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            TR.Show_Message("تم تعديل عرض  برقم");
            sqlDataSource1.Fill();
            pnl_1.Enabled = false;
            Amal(false);
            btn_edit.Enabled = false;
            btn_new.Enabled = true;
            CLEAR_TEXT_BOX(this);
            TR.EnterLog(": تم تعديل عرض  برقم "  + Show_ID);
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }

        private void txtQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }

        private void comb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    MaxMaize_ServiceQuantity(Convert.ToInt32(comb_type.SelectedValue));

            //}
            //catch
            //{
            //    return;
            //}
        }
    }
}

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

namespace SamarPro.Views
{
    public partial class frmProduct : Form
    {
        frmformView FR = new frmformView();
        TransationModule TR = new TransationModule();
        DropShaddow dr = new DropShaddow();
        public int Product_ID; // for any ID Of Each form 
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

        void Case_Marketing(Boolean c_ase)
        {
            txt_comm.Enabled = c_ase;
            txt_discount.Enabled = c_ase;
            txt_Juomla.Enabled = c_ase;
            txtSales.Enabled = c_ase;
            combo_supplaier.Enabled = c_ase;
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
            SqlCommand cmd = new SqlCommand("select BarCode as Bar from Products WHERE BarCode = '"+ txt_Code.Text +"'", DAL.Sqlconnection);
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
        void combo()
        {
            comb_type.DataSource = BL.get_subgate();
            comb_type.DisplayMember = "Name";
            comb_type.ValueMember = "ID";

            combo_supplaier.DataSource = BL.SELECT_Supplaier();
            combo_supplaier.DisplayMember = "Name";
            combo_supplaier.ValueMember = "ID";
        }
        public frmProduct()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            RAD_Sales.Checked = true;            
            groupBox1.Enabled = false;
            Amal(false);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            groupBox1.Enabled = true;
            txtQuan.Enabled = true;
            txtQuan.ReadOnly = false;
            btn_save.Enabled = true;
            btn_new.Enabled = false;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
            payDate.Text = DateTime.Now.ToShortDateString();
            ExpiredDate.Text = DateTime.Now.ToShortDateString();
            EnteryDate.Text = DateTime.Now.ToShortDateString();
            combo();           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // this code for save data in database
            if (txt_Code.Text == string.Empty || txtName.Text == string.Empty ||  txtQuan.Text == string.Empty)
            {
                TR.Show_Message("الرجاء إدخال جميع الحقول");
                return;
            }
            try
            {
                db_model db = new db_model();
                if (RAD_Sales.Checked == true)
                {
                    Product ac = new Product
                    {
                        BarCode = Convert.ToInt16(txt_Code.Text),
                        Name = txtName.Text,
                        PAYmoney = Convert.ToDouble(txtSales.Text),
                        PURCHERmoney = Convert.ToDouble(txtPay.Text),
                        SUP_name = (combo_supplaier.SelectedText),
                        Quntity = Convert.ToInt32(txtQuan.Text),
                        Uses = Convert.ToInt32("0"),
                        PRDtype = Convert.ToInt32(comb_type.SelectedValue),
                        DayDate = EnteryDate.Value,
                        PayDate = payDate.Value,
                        ExperidDate = ExpiredDate.Value,
                        Discount = Convert.ToDouble(txt_discount.Text),
                        JoumlaRmoney = Convert.ToDouble(txt_Juomla.Text),
                        Commation = Convert.ToDouble(txt_comm.Text),
                        Status = "Sales"
                    };
                    TR.Add_Quantity(Convert.ToInt16(txt_Code.Text), Convert.ToInt32(txtQuan.Text));
                    db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
                else if(RAD_Service.Checked == true)
                {
                    Product ac = new Product
                    {
                        BarCode = Convert.ToInt16(txt_Code.Text),
                        Name = txtName.Text,
                        PAYmoney = Convert.ToDouble("0"),
                        PURCHERmoney = Convert.ToDouble(txtPay.Text),
                        SUP_name = "خدمات",
                        Quntity = Convert.ToInt32(txtQuan.Text),
                        Uses = Convert.ToInt32(txtTimes.Text),
                        PRDtype = Convert.ToInt32(comb_type.SelectedValue),
                        DayDate = EnteryDate.Value,
                        PayDate = payDate.Value,
                        ExperidDate = ExpiredDate.Value,
                        Discount = Convert.ToDouble("0"),
                        JoumlaRmoney = Convert.ToDouble("0"),
                        Commation = Convert.ToDouble("0"),
                        Status = "Services"
                    };
                    TR.Add_Quantity(Convert.ToInt16(txt_Code.Text), Convert.ToInt32(txtQuan.Text));
                    db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }              
                TR.Show_Message("تم إضافة منتج");
                groupBox1.Enabled = false;
                Amal(false);
                btn_save.Enabled = false;
                btn_new.Enabled = true;
                TR.EnterLog(": تم إضافة منتج برقم " + txt_Code.Text);
                CLEAR_TEXT_BOX(this);
                RAD_Sales.Checked = true;
            }
            catch
            {
                return;
            }                    
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (RAD_Sales.Checked == true)
                {
                    if (TXT_QNEW.Visible == false)
                    {
                        TXT_QNEW.Text = "0";
                        db_model db = new db_model();
                        Product ac = new Product
                        {
                            ID = Product_ID,
                            BarCode = Convert.ToInt32(txt_Code.Text),
                            Name = txtName.Text,
                            PAYmoney = Convert.ToDouble(txtSales.Text),
                            PURCHERmoney = Convert.ToDouble(txtPay.Text),
                            SUP_name = (combo_supplaier.SelectedText),
                            Quntity = Q + Convert.ToInt32(TXT_QNEW.Text),
                            Uses = Convert.ToInt32("0"),
                            PRDtype = Convert.ToInt32(comb_type.SelectedValue),
                            DayDate = EnteryDate.Value,
                            PayDate = payDate.Value,
                            ExperidDate = ExpiredDate.Value,
                            Discount = Convert.ToDouble(txt_discount.Text),
                            JoumlaRmoney = Convert.ToDouble(txt_Juomla.Text),
                            Commation = Convert.ToDouble(txt_comm.Text),
                            Status = ST
                        };
                        db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        db_model db = new db_model();
                        Product ac = new Product
                        {
                            ID = Product_ID,
                            BarCode = Convert.ToInt32(txt_Code.Text),
                            Name = txtName.Text,
                            PAYmoney = Convert.ToDouble(txtSales.Text),
                            PURCHERmoney = Convert.ToDouble(txtPay.Text),
                            SUP_name = (combo_supplaier.SelectedText),
                            Quntity = Q + Convert.ToInt32(TXT_QNEW.Text),
                            Uses = Convert.ToInt32("0"),
                            PRDtype = Convert.ToInt32(comb_type.SelectedValue),
                            DayDate = EnteryDate.Value,
                            PayDate = payDate.Value,
                            ExperidDate = ExpiredDate.Value,
                            Discount = Convert.ToDouble(txt_discount.Text),
                            JoumlaRmoney = Convert.ToDouble(txt_Juomla.Text),
                            Commation = Convert.ToDouble(txt_comm.Text),
                            Status = ST
                        };
                        db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                else if (RAD_Service.Checked == true)
                {
                    if (TXT_QNEW.Visible == false)
                    {
                        TXT_QNEW.Text = "0";
                        db_model db = new db_model();
                        Product ac = new Product
                        {
                            ID = Product_ID,
                            BarCode = Convert.ToInt32(txt_Code.Text),
                            Name = txtName.Text,
                            PAYmoney = Convert.ToDouble("0"),
                            PURCHERmoney = Convert.ToDouble(txtPay.Text),
                            SUP_name ="خدمات",
                            Quntity = Q + Convert.ToInt32(TXT_QNEW.Text),
                            Uses = Convert.ToInt32(txtTimes.Text),
                            PRDtype = Convert.ToInt32(comb_type.SelectedValue),
                            DayDate = EnteryDate.Value,
                            PayDate = payDate.Value,
                            ExperidDate = ExpiredDate.Value,
                            Discount = Convert.ToDouble("0"),
                            JoumlaRmoney = Convert.ToDouble("0"),
                            Commation = Convert.ToDouble("0"),
                            Status = ST
                        };
                        db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                    else
                    {
                        db_model db = new db_model();
                        Product ac = new Product
                        {
                            ID = Product_ID,
                            BarCode = Convert.ToInt32(txt_Code.Text),
                            Name = txtName.Text,
                            PAYmoney = Convert.ToDouble("0"),
                            PURCHERmoney = Convert.ToDouble(txtPay.Text),
                            SUP_name =  "خدمات",
                            Quntity = Q + Convert.ToInt32(TXT_QNEW.Text),
                            Uses = Convert.ToInt32(txtTimes.Text),
                            PRDtype = Convert.ToInt32(comb_type.SelectedValue),
                            DayDate = EnteryDate.Value,
                            PayDate = payDate.Value,
                            ExperidDate = ExpiredDate.Value,
                            Discount = Convert.ToDouble("0"),
                            JoumlaRmoney = Convert.ToDouble("0"),
                            Commation = Convert.ToDouble("0"),
                            Status = ST
                        };
                        db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            catch
            {
                return;
            }
            TR.Show_Message("تم تعديل بيانات منتج");
            groupBox1.Enabled = false;
            Amal(false);
            btn_edit.Enabled = false;
            btn_new.Enabled = true;
            BTN_REFRESH.Enabled = false;
            TXT_QNEW.Visible = false;
            LBL_QNEW.Visible = false;
            TXT_QNEW.Text = "0";
            TR.EnterLog(": تم تعديل بيانات منتج برقم " + txt_Code.Text);
            CLEAR_TEXT_BOX(this);
            frmformView fr = new frmformView();
            fr.dgvShow.RefreshDataSource();
            RAD_Sales.Checked = true;
        }                   
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتج المحدد ؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db_model db = new db_model();
                Product ac = (from c in db.Products where c.ID == Product_ID select c).FirstOrDefault();
                db.Products.Where(a => a.ID == Product_ID).Select(s => s).FirstOrDefault();
                db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
                TR.Show_Message("تم حذف المنتج");
                TR.EnterLog(": تم حذف بيانات منتج برقم " + txt_Code.Text);
            }
            else
            {
                TR.Show_Message("تم إلغاء عملية الحذف");
            }
            CLEAR_TEXT_BOX(this);
            RAD_Sales.Checked = true;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
           
        }
        int Q;
        string ST;
        private void BTN_FIND_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
           
            FR.ShowDialog();

            combo();
            btn_del.Enabled = true;
            btn_edit.Enabled = true;
            btn_new.Enabled = true;
            groupBox1.Enabled = true;
            txtQuan.ReadOnly = true;
            LBL_QUAN.Text = "كمية المخزن";
            BTN_REFRESH.Enabled = true;
            try
            {
                ST = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("الحالة"));
                if (ST == "Services")
                {
                    RAD_Service.Checked = true;
                }
                else
                {
                    RAD_Sales.Checked = true;
                }
                Product_ID =Convert.ToInt32(FR.gridView1.GetFocusedRowCellValue("رقم المنتج"));
                txt_Code.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("الباركود"));
                comb_type.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("نوع المنتج"));
                txtName.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("الإسم"));
                combo_supplaier.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("إسم المسوق"));

                txtQuan.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("الكمية"));
                Q = Convert.ToInt32(FR.gridView1.GetFocusedRowCellValue("الكمية"));
                txtTimes.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("مرات الإستخدام"));
                txtPay.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("سعر الشراء"));
                txtSales.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("سعر البيع"));
                txt_Juomla.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("سعر الجملة"));
                txt_comm.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("العلاوة"));
                txt_discount.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("التخفيض"));

                string D1, D2, D3;
                D1 = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("تاريخ الإدخال"));
                EnteryDate.Value = Convert.ToDateTime(D1);
                D2 = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("تاريخ الشراء"));
                payDate.Value = Convert.ToDateTime(D2);
                D3 = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("تاريخ الصلاحية"));
                ExpiredDate.Value = Convert.ToDateTime(D3);               
            }
            catch
            {
                return;
            }
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            LBL_QNEW.Visible = true;
            TXT_QNEW.Visible = true;
        }

        private void txt_Code_Leave(object sender, EventArgs e)
        {
            GET_CODE();
        }

        private void txt_Code_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e );
        }

        private void txtQuan_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.For_Quan(e);
        }

        private void TXT_QNEW_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.For_Quan(e);
        }

        private void txtPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }

        private void txtSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }

        private void txtTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void bunifuCustomTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }
        private void bunifuCustomTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }
        private void bunifuCustomTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }
        private void RAD_Sales_CheckedChanged(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            txtTimes.Enabled = false;
            Case_Marketing(true);        
           
        }
        private void RAD_Service_CheckedChanged(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            txtTimes.Enabled = true;
            Case_Marketing(false);          
        }
    }
}

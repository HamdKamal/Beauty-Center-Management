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

namespace SamarPro.Views
{
    public partial class frmEmployee : Form
    {
        public string state = "add";
        public int EmpID; // for any ID Of Each form 
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
        TransationModule TR = new TransationModule();
        DropShaddow dr = new DropShaddow();
        void CLEAR_TEXT_BOX(Control CN)
        {
            foreach (Control C in CN.Controls)
                if (C is TextBox)

                    ((TextBox)C).Clear();

                else

                    CLEAR_TEXT_BOX(C);

        }
        public void GETEmployee_ID() // this function genrate Id by Increase 1 
        {
            DataTable DT = new DataTable();
            DT = BL.GETEmployee_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            EmpID = id;
        }

        public frmEmployee()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            GETEmployee_ID();
            // this code for save data in database
            foreach (Control txt in grpEmployee.Controls)
            {
                if (txt is TextBox)
                {
                    if (txt.Text == "")
                    {
                        TR.Show_Message("الرجاء إدخال جميع الحقول");   
                        return;
                    }
                }
            }
            
            if (state == "add")
            {
                db_model db = new db_model();
                TBLempoyee ac = new TBLempoyee
                {
                    ID = EmpID,
                    Name = txtname.Text,
                    Jop_Type = txt_type.Text,
                    Adress = txtadress.Text,
                    Salary = Convert.ToDouble(txtsalary.Text),
                    Phone = txtphone.Text,
                    Note = txtnote.Text,
                    HDate = date_time.Value
                };

                db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                TR.Show_Message("تم إضافة موظف جديد");
                showGrid SG = new showGrid();
                SG.GRID_Employee.DataSource = BL.getemployee_dataGrid();
                string SQL = ": تم إضافة موظف جديد بإسم  " + txtname.Text;
                TR.EnterLog(SQL);
            }

            grpEmployee.Enabled = false;
            txtname.Focus();
            GETEmployee_ID();
            CLEAR_TEXT_BOX(this);

        }    
        private void grpEmployee_MouseHover(object sender, EventArgs e)
        {
            grpEmployee.Enabled = true;
        }

        private void grpEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustString(e);
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }

        private void txtnote_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustString(e);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // this code for save data in database
            foreach (Control txt in grpEmployee.Controls)
            {
                if (txt is TextBox)
                {
                    if (txt.Text == "")
                    {
                        TR.Show_Message("الرجاء إدخال جميع الحقول");
                        return;
                    }
                }
            }
            try
            {
                db_model db = new db_model();
                TBLempoyee ac = new TBLempoyee
                {
                    ID = EmpID,
                    Name = txtname.Text,
                    Jop_Type = txt_type.Text,
                    Adress = txtadress.Text,
                    Salary = Convert.ToDouble(txtsalary.Text),
                    Phone = txtphone.Text,
                    Note = txtnote.Text,
                    HDate = date_time.Value
                };

                db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                TR.Show_Message("تم تعديل بيانات موظف");
                showGrid SG = new showGrid();
                SG.GRID_Employee.DataSource = BL.getemployee_dataGrid();
                string SQL = ": تم تعديل موظف  بإسم  " + txtname.Text;
                TR.EnterLog(SQL);
                CLEAR_TEXT_BOX(this);
            }
            catch
            {

                return;
            }
            this.Close();
        }
    }
}

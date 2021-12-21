using Bunifu.Framework.UI;
using System;
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
    public partial class frmPermaition : Form
    {
        TransationModule TR = new TransationModule();
        public void HD()
        {
            db_model db = new db_model();
            TBLuser ac = new TBLuser
            {
                ID = User_ID,
                Em_ID = EMP_ID,
                Name = U_Name,
                PassWord = U_Pass,
                Type = U_Type,
                Product = C_PRD.Value,
                Service = C_SER.Value,
                Rent = C_RENT.Value,
                Show = C_SHOW.Value,
                Gategory = C_GATE.Value,
                Bank = C_BANK.Value,
                Expenses = C_EXPENSES.Value,
                Employee = C_EMP.Value,
                Supplaier = C_SUP.Value,
                Storage = C_STORAGE.Value,
                Pos = C_POS.Value,
                Rent_Pos = C_RENTPOS.Value,
                User = C_USER.Value,
                Employee_Add = C_EMP_MANAGE.Value,
                PayRoll = C_PAYROLL.Value,
                Reservation = C_RES.Value,
                Logs = C_LOGS.Value,
                Permiation = C_PERM.Value,
                Bac_Res = C_BAC.Value,
                Res_Paid = C_ResPaid.Value,
                Attend = C_ATTEND.Value,
                show_Pos = C_SHOW_P.Value
            };

            db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        int User_ID,EMP_ID;
        string U_Name, U_Pass;

        StringBuilder str = new StringBuilder();
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();

        private void btnDel_Click(object sender, EventArgs e)
        {
            Boolean C1 = false, C2 = false, C3 = false, C4 = false, C5 = false, C6 = false, C7 = false, C8 = false, C9 = false, C10 = false, C11 = false, C12 = false, C13 = false, C14 = false, C15 = false, C16 = false, C17 = false, C18 = false, C19 = false, C20 = false, C21 = false, C22 = false;
            db_model db = new db_model();
            TBLuser ac = new TBLuser
            {
                ID = User_ID,
                Em_ID = EMP_ID,
                Name = U_Name,
                PassWord = U_Pass,
                Type = U_Type,
                Product = C1,
                Service = C2,
                Rent = C3,
                Show = C4,
                Gategory = C5,
                Bank = C6,
                Expenses = C7,
                Employee = C8,
                Supplaier = C9,
                Storage = C10,
                Pos = C11,
                Rent_Pos = C12,
                User = C13,
                Employee_Add = C14,
                PayRoll = C15,
                Reservation = C16,
                Logs = C17,
                Permiation = C18,
                Bac_Res = C19,
                Res_Paid = C20,
                Attend = C21,
                show_Pos = C22
            };

            db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            TR.Show_Message("تم إلغاء صلاحيات المستخدم");
            sqlDataSource2.Fill();
            comb_User.Text = "";
            btnDel.Enabled = false;
            btnEdite.Enabled = false;
            SOLAFA(false);
            TR.EnterLog(" : قمت بإلغاء صلاحيات المستخدم" + comb_User.SelectedText);
        }


        private void btnEdite_Click(object sender, EventArgs e)
        {
            foreach (Control C in pnl_1.Controls)
            {
                if (C is BunifuiOSSwitch)
                {
                    if (((BunifuiOSSwitch)C).Value == true)
                    {
                        HD();
                    }
                    else
                    {
                        HD();
                    }
                }
            }
            TR.Show_Message("تم بإعطاء صلاحيات جديدة ");
            sqlDataSource2.Fill();
            comb_User.Text = " ";
            btnEdite.Enabled = false;
            btnDel.Enabled = false;          
            SOLAFA(false);
            TR.EnterLog(" : قمت بإعطاء صلاحيات للمستخدم" + comb_User.SelectedText );
        }
            private void dgvShow_Click(object sender, EventArgs e)
            {
                btnDel.Enabled = true;
                btnEdite.Enabled = true;            
                pnl_1.Enabled = true;
                //comb_User.Enabled = true;
                try
                {
                    comb_User.Text = " ";
                    comb_User.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("الإسم"));
                    U_Type = Convert.ToString(gridView1.GetFocusedRowCellValue("النوع"));
                    User_ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("الرقم"));
                    EMP_ID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الموظف"));
                    U_Name = Convert.ToString(gridView1.GetFocusedRowCellValue("إسم المستخدم"));
                    U_Pass = Convert.ToString(gridView1.GetFocusedRowCellValue("كلمة المرور"));

                    C_PRD.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("المنتج"));
                    C_SER.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("الخدمة"));
                    C_RENT.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("الإيجار"));
                    C_SHOW.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("العرض"));

                    C_GATE.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("الفئات"));
                    C_BANK.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("البنك"));
                    C_EXPENSES.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("المصروفات"));
                    C_EMP.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("الموظفين"));
                    C_SUP.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("الموردين"));

                    C_POS.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("البيع"));
                    C_STORAGE.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("المخزن"));
                    C_RENTPOS.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("بيع إيجار"));
                    C_USER.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("المستخدم"));
                    C_EMP_MANAGE.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("إضافة موظفين"));
                    C_PAYROLL.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("المرتبات"));

                    C_RES.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("الحجوزات"));
                    C_LOGS.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("السجلات"));
                    C_PERM.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("الصلاحيات"));
                    C_BAC.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("الداتابيس"));
                    C_ResPaid.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("دفع حجز"));
                    C_ATTEND.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("الحضور"));
                    C_SHOW_P.Value = Convert.ToBoolean(gridView1.GetFocusedRowCellValue("فواتير العرض"));
            }
                catch
                {
                    return;
                }

            }
            string U_Type;
            private void frmPermaition_Load(object sender, EventArgs e)
            {
                SOLAFA(false);
                COM_ID();
            }

            private void comb_User_SelectedIndexChanged(object sender, EventArgs e)
            {
                //comb_User.Enabled = false;
            }

            private void bunifuImageButton1_Click(object sender, EventArgs e)
            {
                Close();
            }

            public void COM_ID()  // fill combobox from data base
            {
                comb_User.DataSource = BL.get_NAME();
                comb_User.DisplayMember = "Name";
                comb_User.ValueMember = "ID";
            }
            private void btnNew_Click(object sender, EventArgs e)
            {
                //btnEdite.Enabled = true;
                //btnDel.Enabled = false;
                //comb_User.Enabled = true;
                //pnl_1.Enabled = true;
                //btnNew.Enabled = false;
            }
            void SOLAFA(Boolean SOLA)
            {
                C_PRD.Value = SOLA;
                C_SER.Value = SOLA;
                C_RENT.Value = SOLA;
                C_SHOW.Value = SOLA;
                C_GATE.Value = SOLA;
                C_BANK.Value = SOLA;
                C_EXPENSES.Value = SOLA;
                C_EMP.Value = SOLA;
                C_EMP_MANAGE.Value = SOLA;
                C_SUP.Value = SOLA;
                C_STORAGE.Value = SOLA;
                C_POS.Value = SOLA;
                C_RENTPOS.Value = SOLA;
                C_USER.Value = SOLA;
                C_PAYROLL.Value = SOLA;
                C_RES.Value = SOLA;
                C_LOGS.Value = SOLA;
                C_PERM.Value = SOLA;
                C_BAC.Value = SOLA;
                C_ResPaid.Value = SOLA;
                C_ATTEND.Value = SOLA;
                C_SHOW_P.Value = SOLA;

                pnl_1.Enabled = SOLA;
                btnEdite.Enabled = SOLA;
                btnDel.Enabled = SOLA;
            }

        private void bunifuGradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_1_Paint(object sender, PaintEventArgs e)
        {

        }

        public frmPermaition()
            {
                InitializeComponent();
                COM_ID();
                SOLAFA(false);
                // This line of code is generated by Data Source Configuration Wizard
                // Fill a SqlDataSource
                sqlDataSource2.Fill();
            }

            private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
            {

            }
        }
}

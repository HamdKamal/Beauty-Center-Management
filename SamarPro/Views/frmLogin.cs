using BookShopManagement.Forms;
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
    public partial class frmLogin : Form
    {
        public int log_id;
        public string log_name;

        TransationModule TR = new TransationModule();
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
        frmMainPage frm = new frmMainPage();
       
        public void check()
        {
            if (txt_name.Text == string.Empty | txt_pass.Text == string.Empty)
            {
               // MessageBox.Show("!يوجد خطأ في تسجيل الدخول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TR.Show_Message("يوجد خطأ في تسجيل الدخول");
                return;
            }
            DataTable DT = BL.log_user(txt_type.Text, txt_name.Text, txt_pass.Text);
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][3].ToString() == "Admin")
                {
                    log_name = DT.Rows[0]["Name"].ToString();
                    log_id = Convert.ToInt16(DT.Rows[0]["ID"]);
                    Program.Casheir_ID = log_id;

                    frm.nav_Pos.Enabled = Convert.ToBoolean(DT.Rows[0]["POS"]);
                    frm.Nav_RentPos.Enabled = Convert.ToBoolean(DT.Rows[0]["Rent_Pos"]);
                    frm.nav_Reservation.Enabled = Convert.ToBoolean(DT.Rows[0]["Reservation"]);
                    frm.nav_Products.Enabled = Convert.ToBoolean(DT.Rows[0]["Product"]);
                    frm.nav_Service.Enabled = Convert.ToBoolean(DT.Rows[0]["Service"]);

                    frm.nav_Rent.Enabled = Convert.ToBoolean(DT.Rows[0]["Rent"]);
                    frm.nav_Show.Enabled = Convert.ToBoolean(DT.Rows[0]["Show"]);
                    frm.nav_Gategory.Enabled = Convert.ToBoolean(DT.Rows[0]["Gategory"]);
                    frm.nav_Expenses.Enabled = Convert.ToBoolean(DT.Rows[0]["Bank"]);
                    frm.navBarItem12.Enabled = Convert.ToBoolean(DT.Rows[0]["Expenses"]);

                    frm.nav_EmpAdd.Enabled = Convert.ToBoolean(DT.Rows[0]["Employee_Add"]);
                    frm.nav_Supplaier.Enabled = Convert.ToBoolean(DT.Rows[0]["Supplaier"]);
                    frm.nav_Products.Enabled = Convert.ToBoolean(DT.Rows[0]["Storage"]);
                    frm.nav_UserManage.Enabled = Convert.ToBoolean(DT.Rows[0]["User"]);
                    frm.nav_EmpPayRoll.Enabled = Convert.ToBoolean(DT.Rows[0]["PayRoll"]);

                    frm.nav_Logs.Enabled = Convert.ToBoolean(DT.Rows[0]["Logs"]);
                    frm.nav_Permistion.Enabled = Convert.ToBoolean(DT.Rows[0]["Permiation"]);
                    frm.nav_DataBase.Enabled = Convert.ToBoolean(DT.Rows[0]["Bac_Res"]);
                    frm.nav_EmpManage.Enabled = Convert.ToBoolean(DT.Rows[0]["Employee"]);
                    frm.nav_PaymentRes.Enabled = Convert.ToBoolean(DT.Rows[0]["Res_Paid"]);
                    frm.bunifuImageButton3.Enabled = Convert.ToBoolean(DT.Rows[0]["Attend"]);
                    frm.navBarItem1.Enabled = Convert.ToBoolean(DT.Rows[0]["show_Pos"]);

                    frm.lbl_type.Text = "مدير النظام";
                    frm.bnt_Mtype.Text = "Admin";
                    frm.lbl_name.Text = log_name;
                    this.Hide();
                    frm.ShowDialog();
                    string FUN = "تم تسجيل الدخول للنظام  ";
                    TR.EnterLog(FUN);
                }
            }
            if (DT.Rows.Count > 0)
            {
                if (DT.Rows[0][3].ToString() == "User")
                {

                    log_name = DT.Rows[0]["Name"].ToString();
                    log_id = Convert.ToInt16(DT.Rows[0]["ID"]);
                    Program.Casheir_ID = log_id;

                    frm.nav_Pos.Enabled = Convert.ToBoolean(DT.Rows[0]["POS"]);
                    frm.Nav_RentPos.Enabled = Convert.ToBoolean(DT.Rows[0]["Rent_Pos"]);
                    frm.nav_Reservation.Enabled = Convert.ToBoolean(DT.Rows[0]["Reservation"]);
                    frm.nav_Products.Enabled = Convert.ToBoolean(DT.Rows[0]["Product"]);
                    frm.nav_Service.Enabled = Convert.ToBoolean(DT.Rows[0]["Service"]);

                    frm.nav_Rent.Enabled = Convert.ToBoolean(DT.Rows[0]["Rent"]);
                    frm.nav_Show.Enabled = Convert.ToBoolean(DT.Rows[0]["Show"]);
                    frm.nav_Gategory.Enabled = Convert.ToBoolean(DT.Rows[0]["Gategory"]);
                    frm.nav_Expenses.Enabled = Convert.ToBoolean(DT.Rows[0]["Bank"]);
                    frm.navBarItem12.Enabled = Convert.ToBoolean(DT.Rows[0]["Expenses"]);

                    frm.nav_EmpAdd.Enabled = Convert.ToBoolean(DT.Rows[0]["Employee_Add"]);
                    frm.nav_Supplaier.Enabled = Convert.ToBoolean(DT.Rows[0]["Supplaier"]);
                    frm.nav_Products.Enabled = Convert.ToBoolean(DT.Rows[0]["Storage"]);
                    frm.nav_UserManage.Enabled = Convert.ToBoolean(DT.Rows[0]["User"]);
                    frm.nav_EmpPayRoll.Enabled = Convert.ToBoolean(DT.Rows[0]["PayRoll"]);

                    frm.nav_Logs.Enabled = Convert.ToBoolean(DT.Rows[0]["Logs"]);
                    frm.nav_Permistion.Enabled = Convert.ToBoolean(DT.Rows[0]["Permiation"]);
                    frm.nav_DataBase.Enabled = Convert.ToBoolean(DT.Rows[0]["Bac_Res"]);
                    frm.nav_EmpManage.Enabled = Convert.ToBoolean(DT.Rows[0]["Employee"]);
                    frm.nav_PaymentRes.Enabled = Convert.ToBoolean(DT.Rows[0]["Res_Paid"]);
                    frm.bunifuImageButton3.Enabled = Convert.ToBoolean(DT.Rows[0]["Attend"]);
                    frm.navBarItem1.Enabled = Convert.ToBoolean(DT.Rows[0]["show_Pos"]);

                    frm.lbl_type.Text = "موظف";
                    frm.bnt_Mtype.Text = "User";
                    frm.lbl_name.Text = log_name;
                    this.Hide();
                    frm.ShowDialog();
                    string FUN = "تم تسجيل الدخول للنظام  ";
                    TR.EnterLog(FUN);
                }
            }
            else
                TR.Show_Message("فشل تسجيل الدخول");
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        } 
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_pass.Text = "";
            try
            {
                if (SamarPro.Properties.Settings.Default.Counter >= 1)
                    return;
                else if (SamarPro.Properties.Settings.Default.Counter == 0)
                {
                    Server_Confiq SYS = new Server_Confiq();
                    SYS.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                TR.Show_Message("فشل الإتصال بالسيرفر");
            }
            txt_name.Focus();
        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            check();
            
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

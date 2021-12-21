using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using SamarPro.Reports;

namespace SamarPro.Views
{
    public partial class frmMainPage : Form
    {
        string num, num1, num2,num3;
        SqlCommand cmd, cmd1, cmd2,cmd3;
        SqlDataReader dr, dr1, dr2,dr3;
        Notification_Alert Notif = new Notification_Alert();
        CONTROLS.DataAccessLayer DAL = new CONTROLS.DataAccessLayer();
        public object BL { get; private set; }
        
        public void CLOSECHILDFORM()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == "frmformView")
                {
                }
                else
                {
                    frm.Close();
                }
            };
        }
        void visible_frm(Boolean x)
        {
            navBarItem5.Enabled = x;
            navBarItem6.Enabled = x;
            navBarItem7.Enabled = x;
            navBarItem8.Enabled = x;
            navBarItem10.Enabled = x;

            // Reports

            navBarItem16.Enabled = x;
            navBarItem14.Enabled = x;
            navBarItem13.Enabled = x;
            navBarItem4.Enabled = x;
            navBarItem19.Enabled = x;
            navBarItem17.Enabled = x;
        }
        void get_task()
        {
            try
            {
                timer3.Start();                         
                String products = "";
                DAL.open();
                SqlCommand cmd = new SqlCommand("select CUSname as cust from Reservations Where  RESdate = '" + DateTime.Now.ToShortDateString() + "' ", DAL.Sqlconnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        products = "لديك حجوزات اليوم بإسم :  " +  dr["cust"] + "   ";
                        
                    }
                    else
                    {
                        label5.Text = "ليس لديك حجوزات لهذا اليوم";
                    }
                }
                   DAL.close();
                   label5.Text = products;
            }
            catch
            {
                return;
            }                      
        }
        void Diseble_Report(Boolean Sol)
        {
            btn_edit.Visible = Sol;
            btn_save.Visible = Sol;
            bunifuFlatButton2.Visible = Sol;
            bunifuFlatButton1.Visible = Sol;
            pictureBox1.Visible = Sol;
            pictureBox2.Visible = Sol;
            pictureBox3.Visible = Sol;
            pictureBox4.Visible = Sol;          
            lbl_sales.Visible = Sol;           
            label4.Visible = Sol;
            label6.Visible = Sol;
        }
        void CLEAR_TEXT_BOX()
        {
            bunifuFlatButton1.TextAlign = ContentAlignment.BottomCenter;
            bunifuFlatButton2.TextAlign = ContentAlignment.BottomCenter;
            btn_save.TextAlign = ContentAlignment.BottomCenter;
            btn_edit.TextAlign = ContentAlignment.BottomCenter;
        }
        void noti()
        {
            try
            {
                DAL.open();
                cmd3 = new SqlCommand("select count(ID) as count from dbo.Products  WHERE  DAY(ExperidDate)>=DAY(DATEADD(month, 0, GETDATE())) + 2", DAL.Sqlconnection);
                dr3 = cmd3.ExecuteReader();
                dr3.Read();

                num3 = dr3["count"].ToString();
                if (num3 == "0")
                {
                    Notif.lbl_notification.Visible = false;
                    return;
                }
                else
                {
                    Notif.lbl_notification.Text = " يوجد " + num3 + " " + "من المنتجات أقترب تاريخ إنتهاء صلاحيتهم  ";
                }
                dr3.Close();
                DAL.close();
            }
            catch
            {
                return;
            }
           
        }
        void lable_NOTIF()
        {
            try
            {
                DAL.open();
                DateTime nowPlusOneWeek = DateTime.Now + new TimeSpan(3, 0, 0, 0);
                cmd = new SqlCommand("select count(ID) as count from Shows where DAY(Edate) >= DAY(DATEADD(month, 0, GETDATE())) + 3", DAL.Sqlconnection);
                dr = cmd.ExecuteReader();
                dr.Read();
                num = dr["count"].ToString();

                if (num == "0")
                {
                    L_SHOW.Text = "";
                    Notif.label1.Visible = false;
                }
                else
                {
                    Notif.label1.Text = "يوجد عدد " + num + " " + "عروض شارفت على الإنتهاء ";                 
                    L_SHOW.Text = num;

                }
                dr.Close();
                DAL.close();


                /// ...........//////////////
                /// 
                DAL.open();
                cmd1 = new SqlCommand("select count(ID) as count from dbo.Products  WHERE Quntity <= 5", DAL.Sqlconnection);
                dr1 = cmd1.ExecuteReader();
                dr1.Read();

                num1 = dr1["count"].ToString();
                if (num1 == "0")
                {
                 Notif.label2.Visible = false;
                    L_PRD.Text = "";
                }
                else
                {
                    Notif.label2.Text = " كمية " + num1 + "  " + "  من المنتجات شارفت على الإنتهاء ";                 
                    L_PRD.Text = num1;
                }
                dr1.Close();
                DAL.close();


                DAL.open();
                cmd2 = new SqlCommand("select count(Code) as count from Reservations WHERE DAY(RESdate)>= DAY(DATEADD(month, 0, GETDATE()))+ 2", DAL.Sqlconnection);
                dr2 = cmd2.ExecuteReader();
                dr2.Read();

                num2 = dr2["count"].ToString();
                if (num2 == "0")
                {
                 Notif.label3.Visible = false;
                    L_RES.Text = "";
                }
                else
                {
                    Notif.label3.Text = "يوجد عدد " + num2 + " " + "حجوزات أقترب موعدهم";
                    L_RES.Text = num2;
                }
                dr2.Close();
                DAL.close();


                DAL.open();
                cmd3 = new SqlCommand("select count(ID) as count from dbo.Products  WHERE  DAY(ExperidDate)>= DAY(DATEADD(month, 0, GETDATE()))+ 3", DAL.Sqlconnection);
                dr3 = cmd3.ExecuteReader();
                dr3.Read();

                num3 = dr3["count"].ToString();
                if (num3 == "0")
                {
                    return;
                }
                else
                {
                    Notif.lbl_notification.Text = " يوجد " + num3 + " " + "من المنتجات أقترب تاريخ إنتهاء صلاحيتهم  ";
                }               
                dr3.Close();
                DAL.close();
            }
            catch
            {
                return;
            }
            Notif.ShowDialog();
        }

        void lbl_sum_sales()
        {
            db_model db = new db_model();
            var result = (from T in db.PosProducts select (int)T.Money).Sum();
            lbl_sales.Text = result.ToString();
        }
        public frmMainPage()
        {
            InitializeComponent();
           
            timer1.Start();
            CLEAR_TEXT_BOX();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" هل تريد تسجيل الخروج  ", " تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
            Diseble_Report(true);
        }


        private void frmMainPage_Load(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX();
            timer2.Start();
            get_task();

            CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
            DataTable DT =BL.get_name_Employee(lbl_name.Text);
            lbl_name.Text = Convert.ToString(DT.Rows[DT.Rows.Count - 1][0]);
            Program.Casheir_Name = lbl_name.Text;
            lbl__date.Text = DateTime.Now.ToLongDateString();
            lbl_sum_sales();
            L_PRD.Text = "";
            L_RES.Text = "";
            L_SHOW.Text = "";     
            if(bnt_Mtype.Text == "Admin")
            {
                visible_frm(true);
                Diseble_Report(true);
            }
            else
            {
                visible_frm(false);
                Diseble_Report(false);
            }
        }

        
        private void button8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_watch.Text = DateTime.Now.ToShortTimeString().ToString();
        }

        private void nav_Pos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
            Diseble_Report(false);
            frmPos frm = new frmPos();
            frm.ShowDialog();
        }

        private void Nav_RentPos_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
           
            frmRentPos frm = new frmRentPos();
            frm.ShowDialog();
        }

        private void nav_Reservation_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
          
            frmReservation frm = new frmReservation();
            frm.ShowDialog();
        }

        private void nav_PaymentRes_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
         
            frmManagement frm = new frmManagement();
            frm.ShowDialog();
        }

        private void nav_EmpAdd_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
         
            frmEmployee frm = new frmEmployee();
            frm.ShowDialog();
        }

        private void nav_EmpManage_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
           
            showGrid frm = new showGrid();
            frm.ShowDialog();
        }

        private void nav_AddBank_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frmTutotial frm = new frmTutotial();
            frm.ShowDialog();
        }

        private void nav_Expenses_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frmTutorialReg frm = new frmTutorialReg();
            frm.ShowDialog();
        }

        private void nav_Products_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
        }

        private void nav_Supplaier_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            
            frmSupplaier frm = new frmSupplaier();
            frm.ShowDialog();
        }

        private void nav_Rent_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
          
            frmRent frm = new frmRent();
            frm.ShowDialog();
        }

        private void nav_Service_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
     
            frmServices frm = new frmServices();
            frm.ShowDialog();
        }

        private void nav_Gategory_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
       
            frmGategory frm = new frmGategory();
            frm.ShowDialog();
        }

        private void nav_Show_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
         
            frmShow frm = new frmShow();
            frm.ShowDialog();
        }

        private void nav_Logs_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
          
            frmLogs frm = new frmLogs();
            frm.ShowDialog();
        }

        private void nav_UserManage_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
        
            frmUser frm = new frmUser();
            frm.ShowDialog();
        }

        private void nav_Permistion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
          
            frmPermaition frm = new frmPermaition();
            frm.ShowDialog();
        }

        private void nav_DataBase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
          
            frmBac_Res frm = new frmBac_Res();
            frm.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Diseble_Report(false);
         
            frmAttendance frm = new frmAttendance();
            frm.ShowDialog();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
            Sales_Report RT = new Sales_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Genaral_Report RT = new Genaral_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Daily_Report RT = new Daily_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Expenses_Report RT = new Expenses_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            lbl_sum_sales();
            get_task();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
           
            lable_NOTIF();
            timer2.Stop();
        }

        private void nav_EmpPayRoll_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frm_EmpPayroll frm = new frm_EmpPayroll();
            frm.ShowDialog();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Payroll_Report RT = new Payroll_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            Daily_Report RT = new Daily_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Genaral_Report RT = new Genaral_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Storage RT = new Storage();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Sales_Report RT = new Sales_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Diseble_Report(false);
            frmPos frm = new frmPos();
            frm.ShowDialog();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frm_Shakawi frm = new frm_Shakawi();
            frm.ShowDialog();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label5.Location = new Point(label5.Location.X + 5, label5.Location.Y);
            if (label5.Location.X > panel2.Width)
            {

                label5.Location = new Point(0 - label5.Width, label5.Location.Y);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frm_work frm = new frm_work();
            frm.ShowDialog();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
         
            Diseble_Report(false);
            frmResource frm = new frmResource();
            frm.ShowDialog();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            Diseble_Report(false);
            FRM_RessourceProduct frm = new FRM_RessourceProduct();
            frm.ShowDialog();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
            Diseble_Report(false);
            ResourceNotify frm = new ResourceNotify();
            frm.ShowDialog();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
            Diseble_Report(false);
            FRM_BOX frm = new FRM_BOX();
            frm.ShowDialog();
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frmResource_POS frm = new frmResource_POS();
            frm.ShowDialog();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frmExpenses frm = new frmExpenses();
            frm.ShowDialog();
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Course_Report RT = new Course_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Resource_SalesReport RT = new Resource_SalesReport();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            QUAN_MAX_Report RT = new QUAN_MAX_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Storage RT = new Storage();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            EXpired_Report RT = new EXpired_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Payment_Report RT = new Payment_Report();
            ReportPrintTool printTool = new ReportPrintTool(RT);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
        }

        private void nav_Project_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frmProject frm = new frmProject();
            frm.ShowDialog();
        }

        private void nav_Devlopers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frmDeveloper frm = new frmDeveloper();
            frm.ShowDialog();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Diseble_Report(false);
            frmshow_offers frm = new frmshow_offers();
            frm.ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            if (num != "0")
            {
                show_notifi frm = new show_notifi();
                frm.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (num2 != "0")
            {
                frmRes_Notific frm = new frmRes_Notific();
                frm.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            if (num1 != "0")
            {
                product_notific frm = new product_notific();
                frm.ShowDialog();
            }
            else
            {
                return;
            }
        }
    }
}

using DevExpress.XtraReports.UI;
using SamarPro.Reports;
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

namespace SamarPro.Views
{
    public partial class frm_work : Form
    {

        TransationModule TR = new TransationModule();
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
        CONTROLS.DataAccessLayer DAL = new CONTROLS.DataAccessLayer();
        DateTime day_date;
        void CLEAR_TEXT_BOX(Control CN)
        {

            foreach (Control C in CN.Controls)
                if (C is TextBox)

                    ((TextBox)C).Clear();

                else

                    CLEAR_TEXT_BOX(C);

        }
        void Emptey_TEXT_BOX(Control CN)
        {

            foreach (Control C in CN.Controls)
                if (C is TextBox)

                   if( ((TextBox)C).Text == string.Empty)
                    {
                        TR.Show_Message("الرجال إدخال جميع الحقول");
                        return;
                    }
        }
        void Amal(Boolean SOL)
        {
            btn_save.Enabled = SOL;
        }
        void GET_name()
        {
            DAL.open();
            SqlCommand cmd = new SqlCommand("select Employee as EMP from Contracts WHERE Employee = '" + combo_Emp.Text + "'", DAL.Sqlconnection);
            SqlDataReader red = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            string ttx = (combo_Emp.Text);

            if (red.HasRows)
            {
                red.Read();
                if (red["EMP"].ToString() == ttx)
                {
                    TR.Show_Message("تنبيه ! تم إضافة هذا العقد من قبل  ");
                }
            }
            red.Close();
            DAL.close();
        }
        public frm_work()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_work_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                CLEAR_TEXT_BOX(this);
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                btn_save.Enabled = true;
                btn_Print.Enabled = true;
                btn_new.Enabled = false;
                day_date = DateTime.Now.Date;
            }
            catch
            {
                return;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtnationality.Text == string.Empty || txtCom.Text == string.Empty || txtCom_Phone.Text == string.Empty)
            {
                TR.Show_Message("الرجال إدخال جميع الحقول");
                return;
            }
            GET_name();
            try
            {
                db_model db = new db_model();
                Contracts ac = new Contracts
                {
                    Day_Date = day_date,
                    Company = txtCom.Text,
                    Reg_No = Convert.ToInt32(txtReq.Text),
                    Fax = Convert.ToInt32(txtfax.Text),
                    Admin = txtAdmin.Text,
                    Com_Phone = txtCom_Phone.Text,
                    Com_Address = txtAddress.Text,
                    Zip_Code = Convert.ToInt32(txtZip.Text),
                    Com_Email = txtComEmail.Text,
                    Employee = combo_Emp.Text,
                    Nationality = txtnationality.Text,
                    PassPort = txtPassport.Text,
                    Export_Owner = txtExport.Text,
                    Export_Date = txtExpDate.Text,
                    Card_Id = Convert.ToInt32(txtCard.Text),
                    Emp_Email = txtEmpEmail.Text
                };

                db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                sqlDataSource1.Fill();
            }
            catch
            {
                return;
            }
            TR.Show_Message("تم  توقيع عقد لموظف جديد ");


            this.Cursor = Cursors.WaitCursor;
            Contract_Report TK = new Contract_Report();
            TK.Parameters["Contract_Code"].Value = combo_Emp.Text;
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;
            TR.EnterLog(": تم إضافة عقد  بإسم  " + combo_Emp.Text);


            Amal(false);
            btn_save.Enabled = false;
            btn_new.Enabled = true;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            CLEAR_TEXT_BOX(this);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Contract_Report TK = new Contract_Report();
            TK.Parameters["Contract_Code"].Value = combo_Emp.Text;
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;
            TR.EnterLog(": تم إضافة عقد  بإسم  " + combo_Emp.Text);
            btn_Print.Enabled = false;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

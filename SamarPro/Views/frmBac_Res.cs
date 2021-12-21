using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
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
    public partial class frmBac_Res : Form
    {
        //SqlConnection sqlconn = new SqlConnection(@"Data Source = (LocalDb)\MSSQLLocalDB; Initial Catalog = SamarPro.db_model; Integrated Security = True;MultipleActiveResultSets=True");
        DataAccessLayer DAL = new DataAccessLayer();
        SqlCommand CMD;
        public frmBac_Res()
        {
            InitializeComponent();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            txt_path.BackColor = Color.White;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
        TransationModule TR = new TransationModule();
        private void btnPaste_Click(object sender, EventArgs e)
        {
            TXT_PATH1.BackColor = Color.White;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                TXT_PATH1.Text = openFileDialog1.FileName;
            }
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            if (TXT_PATH1.Text == "")
            {
                TXT_PATH1.BackColor = Color.Red;
                return;
            }
            string strqry = "ALTER Database [SamarPro.db_model] SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore Database [SamarPro.db_model] From Disk ='" + TXT_PATH1.Text + "'";
            CMD = new SqlCommand(strqry, DAL.Sqlconnection);
            DAL.open();
            CMD.ExecuteNonQuery();
            DAL.close();
            TR.Show_Message("تم إستعادة النسخة الإحتياطية بنجاح");
            TXT_PATH1.Text = "";
            TR.EnterLog("تم إستعادة النسخة الإحتياطية بنجاح");
        }
        private void frmBac_Res_Load(object sender, EventArgs e)
        {
            txt_path.Text = "";
            TXT_PATH1.Text = "";
        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
         TR.EnterLog("تم رفع نسخة إحتياطية للإيميل");
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (txt_path.Text == "")
            {
                txt_path.BackColor = Color.Red;
                return;
            }
            string filename = txt_path.Text + "//SamarPro.db_model" + DateTime.Now.ToLongDateString().Replace('/', '-') + " ^ " + DateTime.Now.ToShortTimeString().Replace(':', '-');
            string strqry = "Backup Database [SamarPro.db_model] to Disk ='" + filename + ".bak'";
            CMD = new SqlCommand(strqry, DAL.Sqlconnection);
            DAL.open();
            CMD.ExecuteNonQuery();
            DAL.close();
            TR.Show_Message("تم عمل النسخة الإحتياطية بنجاح");
            txt_path.Text = "";
            TR.EnterLog("تم عمل النسخة الإحتياطية بنجاح");
        }
    }
}

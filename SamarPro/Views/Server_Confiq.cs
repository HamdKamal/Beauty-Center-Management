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
using ShopInvetoryManagement;
using System.Configuration;
using System.Configuration.Provider;

namespace BookShopManagement.Forms
{
    public partial class Server_Confiq : Form
    {
        public Server_Confiq()
        {
            InitializeComponent();
        }

        private void bt_conn_Click(object sender, EventArgs e)
        {
 
                SamarPro.Properties.Settings.Default.Server = txt_server.Text;
                SamarPro.Properties.Settings.Default.DataBase = txt_base.Text;
                SamarPro.Properties.Settings.Default.Mode = rbt_win.Checked == true ? "Windows" : "Windows";
                SamarPro.Properties.Settings.Default.Counter += 1;
                SamarPro.Properties.Settings.Default.Save();

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.ConnectionStrings.ConnectionStrings["db_model"].ConnectionString = "data source='" + txt_server.Text + "';integrated security=True;initial catalog='" + txt_base.Text + "';MultipleActiveResultSets=True";
                config.Save(ConfigurationSaveMode.Modified, true);
                ConfigurationManager.RefreshSection("connectionStrings");

            config.ConnectionStrings.ConnectionStrings["SamarPro.Properties.Settings.ConnectionString"].ConnectionString = "data source='" + txt_server.Text + "';integrated security=True;initial catalog='" + txt_base.Text + "';MultipleActiveResultSets=True";
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");

            TR.Show_Message("... تم تفعيل الإتصال بالسيرفر بنجاح ");
                this.Close();  
        }
        SamarPro.TransationModule TR = new SamarPro.TransationModule();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Server_Confiq_Load(object sender, EventArgs e)
        {
           txt_server.Text =SamarPro. Properties.Settings.Default.Server;
            txt_base .Text =SamarPro.Properties.Settings.Default.DataBase;
            if (SamarPro. Properties.Settings.Default.Mode == "Windows")
                rbt_win.Checked = true;
        }
    }
}


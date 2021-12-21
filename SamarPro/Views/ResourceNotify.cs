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
    public partial class ResourceNotify : Form
    {

        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
        CONTROLS.DataAccessLayer DAL = new CONTROLS.DataAccessLayer();
        private void ResourceNotify_Load(object sender, EventArgs e)
        {          
        }
       
        public void get_Expired(int R_id)
        {
            try
            {
                dt = BL.GET_NOTIFY(R_id);
                dgvShow.DataSource = dt;
            }
            catch 
            {
               return ;
            }
        }
        public ResourceNotify()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        DataTable dt = new DataTable();
        int Resource_ID;
        private void com_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
             Resource_ID = Convert.ToInt16(com_Name.SelectedValue);
             get_Expired(Resource_ID);
        }
    }
}

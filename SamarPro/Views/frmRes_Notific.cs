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
    public partial class frmRes_Notific : Form
    {
        public frmRes_Notific()
        {
            InitializeComponent();
        }

        private void frmRes_Notific_Load(object sender, EventArgs e)
        {
            sqlDataSource1.Fill();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

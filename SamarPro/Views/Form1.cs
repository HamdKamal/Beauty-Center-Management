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
using System.Data.Entity;

namespace WindowsFormsApplication3
{


    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"data source = (LocalDb)\MSSQLLocalDB; initial catalog = aau; integrated security = True");
 

        public Form1()
        {
            InitializeComponent();
            
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
     
            label1.Location = new Point(label1.Location.X + 5, label1.Location.Y);
            if (label1.Location.X > this.Width)
            {

                label1.Location = new Point(0 - label1.Width, label1.Location.Y);


           }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            String products="";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select name  from name", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                products += dr["name"] + "                ";

            }
            conn.Close();
            label1.Text = products;



        }

      
    }
}

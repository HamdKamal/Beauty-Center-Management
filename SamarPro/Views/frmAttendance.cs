﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;

namespace SamarPro
{
    public partial class frmAttendance : Form
    {
        CONTROLS.DataAccessLayer DAL = new CONTROLS.DataAccessLayer();
        TransationModule TR = new TransationModule();
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
        int GT;
        void GET_CODE()
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    DAL.open();
                    string Y = C_YEAR.Text;
                    string M = C_MONTH.Text;
                    string D = C_DAY.Text;

                    string crreturon = Y + "-" + M + "-" + D;
                    SqlCommand cmd = new SqlCommand("select Entery_Date as Status from TBL_Attendance WHERE EmpID = '" + GT + "' and CONVERT(VARCHAR, Entery_Date, 120) LIKE '%" + crreturon + "%' ", DAL.Sqlconnection);
                    SqlDataReader red = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    if (red.HasRows)
                    {
                        while (red.Read())
                        {
                            TR.Show_Message("تم تسجيل الحضور لـ" + " " + com_Emp.Text + "مسبقاً");
                            return;
                        }
                        red.Close();
                        DAL.close();
                    }
                    else
                    {
                        db_model db = new db_model();
                        TBL_Attendance ac = new TBL_Attendance
                        {
                            //// Attend ////
                            EmpID = Convert.ToInt32(com_Emp.SelectedValue),
                            Entery_Date = Convert.ToDateTime(S_work.Text),
                            Attend_Time = DateTime.Now,
                            Status = "حضور",
                            Lave_Date = DateTime.Now,
                            Lave_Time = DateTime.Now,
                        };
                        db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();
                        sqlDataSource1.Fill();
                        TR.Show_Message("تم تسجيل الحضور");
                        btn_edit.Enabled = false;
                        btn_new.Enabled = true;
                        grp_1.Enabled = false;
                    }
                    red.Close();
                    DAL.close();
                }
                if (radioButton2.Checked == true)
                {
                    gridView1.Columns["نهاية الدوام"].Visible = true;
                    gridView1.Columns["زمن الإنصراف"].Visible = true;

                    db_model db = new db_model();
                    TBL_Attendance ac = new TBL_Attendance
                    {
                        ID = X,
                        EmpID = Y,
                        Entery_Date = At_Date,
                        Attend_Time = At_Time,
                        Status = STU,
                        Lave_Date = Convert.ToDateTime(S_work.Text),
                        Lave_Time = DateTime.Now
                    };
                    db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    sqlDataSource1.Fill();
                    TR.Show_Message("تم تسجيل الإنصراف");
                    btn_edit.Enabled = false;
                    btn_new.Enabled = true;
                    grp_1.Enabled = false;
                }
            }
            catch
            {
                return;
            }
        }
        public frmAttendance()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }
        private void frmAttendance_Load(object sender, EventArgs e)
        {
            grp_1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            gridView1.Columns["نهاية الدوام"].Visible = false;
            gridView1.Columns["زمن الإنصراف"].Visible = false;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void com_Emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            GT = Convert.ToInt32(com_Emp.SelectedValue);
            //  MessageBox.Show(com_Emp.SelectedValue.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Start.Text = ": بداية الدوام";
            dr.DesibleCombo(grp_1, true);
            btn_new.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Start.Text = ": نهاية الدوام";
            dr.DesibleCombo(grp_1, false);
            btn_new.Enabled = false;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            grp_1.Enabled = true;
            radioButton1.Enabled = true;
            radioButton1.Checked = true;
            radioButton2.Enabled = true;
            btn_edit.Enabled = true;
            btn_new.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            GET_CODE();          
        }

        int X,Y;
        String STU;
        DateTime At_Date, At_Time;
        CONTROLS.DropShaddow dr = new CONTROLS.DropShaddow();
        private void dgv_Attend_Click(object sender, EventArgs e)
        {
            dr.DesibleCombo(grp_1,false);
            X = Convert.ToInt32(gridView1.GetFocusedRowCellValue("المعرف"));
            com_Emp.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("إسم الموظف"));
            Y = Convert.ToInt16(gridView1.GetFocusedRowCellValue("EMP_ID"));
            STU = Convert.ToString(gridView1.GetFocusedRowCellValue("الحالة"));

            At_Date = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("بداية الدوام"));    
            At_Time = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("زمن الحضور"));
           
            //MessageBox.Show(X.ToString() +" " + At_Time.ToString(), STU + " "+ At_Date.ToString());
        }

    }    
}

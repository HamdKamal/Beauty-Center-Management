using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SamarPro.CONTROLS;
using System.Data.SqlClient;
using SamarPro.Reports;
using DevExpress.XtraReports.UI;

namespace SamarPro.Views
{
    public partial class frm_EmpPayroll : Form
    {
        DropShaddow DCH = new DropShaddow();
        TransationModule TR = new TransationModule();
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
        DataAccessLayer DAL = new DataAccessLayer();
        Double Total_Price = 0;
        Double Total_Price2 = 0;
        Double Total_Price1 = 0;
        int Sum_Hours, over_hours;
        double money, money1;        
        void CLEAR_TEXT_BOX(Control CN)
        {
            foreach (Control C in CN.Controls)
                if (C is TextBox)
                    ((TextBox)C).Clear();
                else
                    CLEAR_TEXT_BOX(C);
        }
        void Get_Salary(int ID)
        {
            try
            {
                db_model db = new db_model();
                var Result = db.TBLempoyees.Where
                        (x => x.ID == ID)
                        .Select(s => new
                        { Money = s.Salary }).ToList();
                if (Result.SingleOrDefault() != null)
                {
                    txt_Salary.Text = Result.SingleOrDefault().Money.ToString();
                }
            }
            catch
            {
                return;
            }
        }
        void get_totalDieon()
        {
            DAL.open();
            SqlCommand cmd1 = new SqlCommand("select isNull(Sum(Money),0) as Bar from Complaintes WHERE E_ID = '" + Emp_ID + "'", DAL.Sqlconnection);
            SqlDataReader red1 = cmd1.ExecuteReader(CommandBehavior.CloseConnection);

            if (red1.HasRows)
            {
                if (red1.Read())
                {
                    Total_Price2 = Convert.ToDouble(red1["Bar"]);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            red1.Close();
            DAL.close();

            ///////////////////////////////////////////////////////////////////////

            DAL.open();
            SqlCommand cmd = new SqlCommand("select isNull(Sum(Money),0) as Bar from Adversaries WHERE EM_ID = '" + Emp_ID + "'", DAL.Sqlconnection);
            SqlDataReader red = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (red.HasRows)
            {
                if (red.Read())
                {
                    Total_Price = Convert.ToDouble(red["Bar"]);
                    txt_SumDieon.Text = (Total_Price + Total_Price2).ToString();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            red.Close();
            DAL.close();
           
        }
        void get_totalbONUS()
        {
            DAL.open();
            SqlCommand cmd = new SqlCommand("select isNull(Sum(Money),0) as Bar from Bonus WHERE EM_ID = '" + Emp_ID + "'", DAL.Sqlconnection);
            SqlDataReader red1 = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (red1.HasRows)
            {
                if (red1.Read())
                {
                    //red1.Read();
                    Total_Price1 = Convert.ToDouble(red1["Bar"]);
                    txt_SumBonus.Text = Total_Price1.ToString();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
            red1.Close();
            DAL.close();
        }
        void Get_Late_Hours()
        {
            DAL.open();
            string Sql = "select IsNull(SUM(DATEDIFF(HOUR,Entery_Date,Attend_Time)),0) as SUM_IN_HOUR  from TBL_Attendance where EmpID = @E_ID and Attend_Time between @date1 and @date2";
            SqlCommand cmd = new SqlCommand(Sql, DAL.Sqlconnection);
            cmd.Parameters.Add("@E_ID", SqlDbType.Int, 30, "EmpID").Value = Emp_ID;
            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Attend_Time").Value = bunifuDatepicker1.Value.Date;
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Attend_Time").Value = Paydate.Value.Date;
            SqlDataReader red2 = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (red2.HasRows)
            {
                while (red2.Read() == true)
                {
                    txt_AdvHours.Text = red2["SUM_IN_HOUR"].ToString();
                    Sum_Hours = Convert.ToInt32(red2["SUM_IN_HOUR"]);
                    // MessageBox.Show(red2["SUM_IN_HOUR"].ToString());
                }
            }
            else
            {
                return;
            }
            red2.Close();
            DAL.close();
        }
        void Get_OverTime()
        {
            DAL.open();
            string Sql = "select IsNull(SUM(DATEDIFF(HOUR,Lave_Date,Lave_Time)),0) as Over_IN_HOUR  from TBL_Attendance where EmpID = @E_ID and Attend_Time between @date1 and @date2";
            SqlCommand cmd = new SqlCommand(Sql, DAL.Sqlconnection);
            cmd.Parameters.Add("@E_ID", SqlDbType.Int, 30, "EmpID").Value = Emp_ID;
            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Attend_Time").Value = bunifuDatepicker1.Value.Date;
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Attend_Time").Value = Paydate.Value.Date;
            SqlDataReader red5 = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            if (red5.HasRows)
            {
                while (red5.Read() == true)
                {
                    txt_overHours.Text = red5["Over_IN_HOUR"].ToString();
                    over_hours = Convert.ToInt32(red5["Over_IN_HOUR"]);                   
                }
            }
            else
            {
                return;
            }
            red5.Close();
            DAL.close();
        }
        double Salary =0 , Bonus_Money=0,Net_Bonus=0,Per =0,Emp_Income;
        void Calculate_NetBonus()
            {
            Salary = Convert.ToDouble(txt_Salary.Text);
            Bonus_Money = Convert.ToDouble(txt_SumBonus.Text);
            try
            {
                if (Bonus_Money <= Salary)
                {
                    Per = 0;
                    Emp_Income = Bonus_Money - Salary;
                    Net_Bonus = (Emp_Income * (Per / 100));
                    TXT_NETBonus.Text = Net_Bonus.ToString();
                    SalesPersent.Text = Per.ToString();
                }
                if (Bonus_Money < Salary * 2 && Bonus_Money > Salary)
                {
                    Per = 0;
                    Emp_Income = Bonus_Money - Salary;
                    Net_Bonus =  (Emp_Income * (Per / 100));
                    TXT_NETBonus.Text = Net_Bonus.ToString();
                    SalesPersent.Text = Per.ToString();
                }
                if (Bonus_Money >= Salary * 2 && Bonus_Money < Salary * 3)
                {
                    Per = 1;
                    Emp_Income = Bonus_Money - Salary;
                    Net_Bonus =  (Emp_Income * (Per / 100));
                    TXT_NETBonus.Text = Net_Bonus.ToString();
                    SalesPersent.Text = Per.ToString();
                }
                if (Bonus_Money >= Salary * 3 && Bonus_Money < Salary * 4)
                {
                    Per = 2;
                    Emp_Income = Bonus_Money - Salary;
                    Net_Bonus = (Emp_Income * (Per / 100));
                    TXT_NETBonus.Text = Net_Bonus.ToString();
                    SalesPersent.Text = Per.ToString();
                }                
                if (Bonus_Money >= Salary * 4 && Bonus_Money < Salary * 5)
                {
                    Per = 3;
                    Emp_Income = Bonus_Money - Salary;
                    Net_Bonus = (Emp_Income * (Per / 100));
                    TXT_NETBonus.Text = Net_Bonus.ToString();
                    SalesPersent.Text = Per.ToString();
                }
                if (Bonus_Money >= Salary * 5 && Bonus_Money < Salary * 6)
                {
                    Per = 4;
                    Emp_Income = Bonus_Money - Salary;
                    Net_Bonus = (Emp_Income * (Per / 100));
                    TXT_NETBonus.Text = Net_Bonus.ToString();
                    SalesPersent.Text = Per.ToString();
                }
                if (Bonus_Money >= Salary * 6)
                {
                    Per = 5;
                    Emp_Income = Bonus_Money - Salary;
                    Net_Bonus =  (Emp_Income * (Per / 100));
                    TXT_NETBonus.Text = Net_Bonus.ToString();
                    SalesPersent.Text = Per.ToString();
                }
            }
            catch
            {
                return;
            }
            }
        public frm_EmpPayroll()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource
            sqlDataSource1.Fill();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        int Emp_ID;
        private void com_Emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Emp_ID = Convert.ToInt32(com_Emp.SelectedValue);
            Get_Salary(Emp_ID);
            get_totalbONUS();
            get_totalDieon();
            //Calculate_NetBonus();
        }
        string S_Date, E_Date;
        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            S_Date = bunifuDatepicker1.Value.ToShortDateString();
        }
        private void txt_SumOver_KeyUp(object sender, KeyEventArgs e)
        {           
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            E_Date = Paydate.Value.ToShortDateString();
            txt_AdvMoney.Enabled = false;
            if (txt_Salary.Text == "")
            {
                return;
            }
            else
            {
                Get_Late_Hours();
                txt_AdvMoney.Enabled = true;
            }
                
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            E_Date = Paydate.Value.ToShortDateString();
            txt_overMoney.Enabled = false;
            if (txt_Salary.Text == "")
            {
                return;
            }
            else
            {
                txt_overMoney.Enabled = true;
                Calculate_NetBonus();
                Get_OverTime();
            }
            
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            grp1.Enabled = true;
            btn_Calculate.Enabled = true;
            btn_save.Enabled = true;
            btn_new.Enabled = false;
            btn_Print.Enabled = true;
            
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_AdvMoney.Text == string.Empty || txt_overMoney.Text == string.Empty)
            {
                TR.Show_Message("الرجاء إدخال جميع الحقول");
                return;
            }
                db_model db = new db_model();
                TBL_EmpPayRoll ac = new TBL_EmpPayRoll
            {
                EMP_Id = Emp_ID,
                    Adv_Hours = Convert.ToInt32(txt_AdvHours.Text),             
                    Bonus_Persent = Convert.ToInt32(SalesPersent.Text),
                    Salary = Convert.ToDouble(txt_Salary.Text),
                    Dion = Convert.ToDouble(txt_SumDieon.Text),
                    Adv_Money = Convert.ToDouble(txt_AdvMoney.Text),
                    Adv_Total = Convert.ToDouble(txt_SumAdv.Text),
                    Bonus_Money = Convert.ToDouble(txt_SumBonus.Text),
                    Bonus_Total = Convert.ToDouble(TXT_NETBonus.Text),
                    Set_Total = Convert.ToDouble(lbl_TotalAdv.Text),
                    Get_Total = Convert.ToDouble(lbl_TotalBonus.Text),
                    Net_Salary = Convert.ToDouble(lbl_Net_Salary1.Text),
                    Over_Hours = Convert.ToDouble(txt_overHours.Text),
                    Over_Money = Convert.ToDouble(txt_overMoney.Text),
                    Total_Overs = Convert.ToDouble(txt_SumOver.Text),
                    Date_Pay = DateTime.Now.Date
                };
                db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                TR.Show_Message("تم صرف راتب الموظف");
                sqlDataSource1.Fill();
                btn_save.Enabled = false;
                btn_new.Enabled = true;
                TR.EnterLog(": تم صرف راتب الموظف " + com_Emp.SelectedText);
                CLEAR_TEXT_BOX(this);
        }

        private void txt_AdvMoney_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_AdvMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            DCH.For_Quan(e);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Employee_PAY TK = new Employee_PAY();
            TK.Parameters["Emp_ID"].Value = Emp_ID;
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;
            btn_Print.Enabled = false;
        }

        private void txt_overMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            DCH.For_Quan(e);
        }

        private void txt_overMoney_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                money1 = Convert.ToDouble(txt_overMoney.Text);
                double Y = money1 * over_hours;
                txt_SumOver.Text = Y.ToString();
                lbl_TotalBonus.Text = (Y + Convert.ToDouble(TXT_NETBonus.Text)).ToString();
            }
            catch
            {
                return;
            }   
        }
        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Net_Salary1.Text = ((Salary + Convert.ToDouble(lbl_TotalBonus.Text)) - Convert.ToDouble(lbl_TotalAdv.Text)).ToString();
            }
            catch
            {
                return;
            }
            btn_Calculate.Enabled = false;
        }
        private void txt_overMoney_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
        private void txt_AdvMoney_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                 money = Convert.ToDouble(txt_AdvMoney.Text);
                 double I = money * Sum_Hours;
                 txt_SumAdv.Text = I.ToString();
                 lbl_TotalAdv.Text = (I + Convert.ToDouble(txt_SumDieon.Text)).ToString();
            }
            catch
            {
                return;
            }
        }
        private void lbl_Net_Salary_Click(object sender, EventArgs e)
        {

        }
        private void Paydate_onValueChanged(object sender, EventArgs e)
        {
            E_Date = Paydate.Value.ToShortDateString();
        }
    }
}

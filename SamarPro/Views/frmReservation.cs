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
    public partial class frmReservation : Form
    {
        public int Reservation_ID,My_ID; // for any ID Of Each form 
        TransationModule TR = new TransationModule();
        CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
        CONTROLS.DropShaddow dr = new CONTROLS.DropShaddow();
        CONTROLS.DataAccessLayer DAL = new CONTROLS.DataAccessLayer();
        SqlCommand cmd1;
        SqlDataReader dr1;
        string E_NAME;
        void CLEAR_TEXT_BOX(Control CN)
        {

            foreach (Control C in CN.Controls)
                if (C is TextBox)

                    ((TextBox)C).Clear();

                else

                    CLEAR_TEXT_BOX(C);

        }
        int Reservation_ID1;
        void GETReservation_ID() // this function genrate Id by Increase 1 
        {
            DataTable DT = new DataTable();
            DT = BL.Get_My_ID();
            int id = Convert.ToInt32(DT.Rows[DT.Rows.Count - 1][0]);
            Reservation_ID1 = id;           
        }
       
        public void get_resTime(int E_ID,string R_time)
        {
            try
            {
                DAL.open();
                string sql = "select Reservation_Time as TIME from Reservations where EmpID = '"+ E_ID + "' and Reservation_Time  = '" + R_time + "' and RESdate = @Date1";
                cmd1 = new SqlCommand(sql, DAL.Sqlconnection);
                cmd1.Parameters.Add("@date1", SqlDbType.DateTime, 30, "RESdate").Value = ResDate.Value.Date;
                dr1 = cmd1.ExecuteReader();               
                dr1.Read();
                if (dr1.HasRows == true)
                {
                   TR.Show_Message("الموظف " + E_NAME +" مقدم الخدمة غير متاح حالياً");                   
                   return;
                }          
                
                dr1.Close();
                DAL.close();
            }
            catch
            {
                return;
            }           
        }
        void Amal(Boolean SOL)
        {
            btndel.Enabled = SOL;
            btnedit.Enabled = SOL;
            btn_save.Enabled = SOL;
        }
        public void COM_ID()  // fill combobox from data base
        {
            combo_Worker.DataSource = BL.get_username();
            combo_Worker.DisplayMember = "Name";
            combo_Worker.ValueMember = "ID";   
        }
        void Edit()
        {
            try
            {
                Paid.ReadOnly = true;
                db_model db = new db_model();
                Reservation ac = new Reservation
                {
                    Code = Reservation_ID,
                    CUSname = txtName.Text,
                    Paid = Convert.ToDouble(Paid.Text),
                    withdrow = Convert.ToDouble(Withdrow.Text),
                    SERTYPE = Convert.ToInt32(comboService.SelectedValue),
                    REStype = combtype.Text,
                    dayDate = DayDate.Value,
                    RESdate = ResDate.Value,
                    Phone = txtPhone.Text,
                    Note = txtNote.Text,
                    EmpID = Convert.ToInt32(combo_Worker.SelectedValue),
                    My_ID = Reservation_ID,
                    Reservation_Time = (Res_Time.Text),
                    Reservation_Time1 = (Res_Time1.Text)
                };
                db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                using (var context = new db_model())
                {
                    var query = from st in context.Bonus
                                where st.RES_ID == Reservation_ID
                                select new { My_ID = st.ID };

                    TR.CalculateBouns_Edit(query.SingleOrDefault().My_ID, Convert.ToInt32(combo_Worker.SelectedValue), Reservation_ID, "Bouns +", Convert.ToDouble(txtPrice.Text));
                }
                TR.Show_Message("تم تعديل بيانات حجز");
                TR.EnterLog(": تم تعديل بيانات حجز برقم " + Reservation_ID);
                Pnl_1.Enabled = false;
                Amal(false);
                btnedit.Enabled = false;
                btn_new.Enabled = true;
                CLEAR_TEXT_BOX(this);
            }
            catch
            {
                TR.Show_Message("تم تعديل بيانات حجز");
                Pnl_1.Enabled = false;
                Amal(false);
                btnedit.Enabled = false;
                btn_new.Enabled = true;
                CLEAR_TEXT_BOX(this);
            }           
        }
        void combo()
        {
            comboService.DataSource = BL.SELECT_Service_Data();
            comboService.DisplayMember = "Name";
            comboService.ValueMember = "ID";
        }
        public frmReservation()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {       
            Close();
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            Pnl_1.Enabled = false;
            Amal(false);
            GETReservation_ID();
            COM_ID();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            dr.DesibleCombo(Pnl_1,true);
            CLEAR_TEXT_BOX(this);
            Pnl_1.Enabled = true;
            btn_save.Enabled = true;
            btn_new.Enabled = false;
            btndel.Enabled = false;
            btnedit.Enabled = false;
            Paid.Enabled = true;
            Paid.ReadOnly = false;
            Paid.Text = "0.00";
            Withdrow.Text = "0.00";
            txtPrice.Text = "0.00";
            ResDate.Text = DateTime.Now.ToShortDateString();
            DayDate.Text = DateTime.Now.ToShortDateString();
            combo();
            COM_ID();
            GETReservation_ID();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty || txtPhone.Text == string.Empty || txtPrice.Text == string.Empty || txtNote.Text == string.Empty)
            {
                TR.Show_Message("الرجاء إدخال جميع الحقول");
                return;
            }

            try
            {
                db_model db = new db_model();
                Reservation ac = new Reservation
                {
                    CUSname = txtName.Text,
                    Paid = Convert.ToDouble(Paid.Text),
                    withdrow = Convert.ToDouble(Withdrow.Text),
                    SERTYPE = Convert.ToInt32(comboService.SelectedValue),
                    REStype = combtype.Text,
                    dayDate = DayDate.Value,
                    RESdate = ResDate.Value,
                    Phone = txtPhone.Text,
                    Note = txtNote.Text,
                    EmpID = Convert.ToInt32(combo_Worker.SelectedValue),
                    My_ID = Reservation_ID1,
                    Reservation_Time = (Res_Time.Text),
                    Reservation_Time1 = (Res_Time1.Text)
                };

                db.Entry(ac).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                TR.Min_Quantity(x);
                TR.CalculateBouns_Save(Convert.ToInt32(combo_Worker.SelectedValue), Reservation_ID1, "Bouns +", Convert.ToDouble(txtPrice.Text));
                TR.EnterLog("تم إضافة حجز جديد");
                TR.Show_Message("تم إضافة حجز جديد");
                Pnl_1.Enabled = false;
                Amal(false);
                btn_save.Enabled = false;
                btn_new.Enabled = true;
                CLEAR_TEXT_BOX(this);
            }
            catch
            {
                TR.Show_Message("تم إضافة حجز جديد");
                CLEAR_TEXT_BOX(this);
                Pnl_1.Enabled = false;
                Amal(false);
                btn_save.Enabled = false;
                btn_new.Enabled = true;
            }           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {  
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            CLEAR_TEXT_BOX(this);
            Paid.ReadOnly = true;
            frmReservationLoad FR = new frmReservationLoad();
            FR.ShowDialog();

            COM_ID();
            combo();
            btn_Print.Enabled = true;
            btndel.Enabled = true;
            btnedit.Enabled = true;
            btn_new.Enabled = true;
            Pnl_1.Enabled = true;
            dr.DesibleCombo(Pnl_1, false);
            combo_Worker.Enabled = true;
            try
            {
                Reservation_ID = Convert.ToInt32(FR.gridView1.GetFocusedRowCellValue("كود الحجز"));
               
                txtName.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("إسم العميل"));
                combtype.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("نوع الحجز"));
                txtPhone.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("رقم الهاتف"));
                txtPrice.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("السعر"));
                combo_Worker.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("إسم الموظف"));

                txtNote.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("ملاحظة"));
                comboService.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("إسم الخدمة"));
                Paid.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("المدفوع"));
                Withdrow.Text = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("المتبقي"));

                string D1, D2,D3,D4;
                D1 = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("التاريخ"));
                DayDate.Value = Convert.ToDateTime(D1);
                D2 = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("تاريخ الحجز"));
                ResDate.Value = Convert.ToDateTime(D2);
                D3 = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("من"));             
                Res_Time.SelectedText = (D3);
                D4 = Convert.ToString(FR.gridView1.GetFocusedRowCellValue("إلى"));
                Res_Time1.SelectedText = (D4);
            }
            catch
            {
                return;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد حذف الحجز المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    db_model db = new db_model();
                    Reservation ac = (from c in db.Reservations where c.Code == Reservation_ID select c).FirstOrDefault();
                    db.Reservations.Where(a => a.Code == Reservation_ID).Select(s => s).FirstOrDefault();
                    db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();

                    using (var context = new db_model())
                    {
                        var query = from st in context.Bonus
                                    where st.RES_ID == Reservation_ID
                                    select new { My_ID = st.ID };

                        TR.CalculateBouns_Delete(query.SingleOrDefault().My_ID, combo_Worker.Text);
                    }                
                    TR.EnterLog(": تم حذف بيانات حجز برقم " + Reservation_ID);
                    TR.Show_Message("تم حذف الحجز ");
                }
                else
                {
                    TR.Show_Message("تم إلغاء عملية الحذف");
                }               
            }
            catch
            {
                TR.Show_Message("تم حذف الحجز ");
            }
            CLEAR_TEXT_BOX(this);
        }
        private void comboService_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }
        int x;
        private void comboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToInt32(comboService.SelectedValue);
                CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
                DataTable DT = BL.get_ser_money(x);
                double s = Convert.ToDouble(DT.Rows[DT.Rows.Count - 1][0]);
                txtPrice.Text = s.ToString();
             
            }
            catch
            {
                return;
            }           
        }
        private void combtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Paid_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void Paid_Leave(object sender, EventArgs e)
        {
            try
            {
                double TOTAL = Convert.ToDouble(txtPrice.Text);
                double MADFO = Convert.ToDouble(Paid.Text);
              if (MADFO > TOTAL)
                {
                    TR.Show_Message("عذراً : المبلغ المدفوع أكبر من المبلغ الكلي");
                    return;
                }
              else
                {
                    double MOTABG = TOTAL - MADFO;
                    Withdrow.Text = MOTABG.ToString();
                }              
            }
            catch
            {
                return;

            }
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Res_Invoice TK = new Res_Invoice();
            TK.Parameters["Res_Code"].Value = Reservation_ID;
            ReportPrintTool printTool = new ReportPrintTool(TK);
            printTool.PreviewForm.StartPosition = FormStartPosition.CenterScreen;
            printTool.ShowPreviewDialog();
            this.Cursor = Cursors.Default;
            TR.EnterLog(": تم إضافة فاتورة حجز برقم  " + Reservation_ID);
            btn_Print.Enabled = false;
        }

        private void comboService_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Paid_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }

        private void Withdrow_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustString(e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            dr.JustNumber(e);
        }

        private void combo_Worker_SelectedIndexChanged(object sender, EventArgs e)
        {
            E_NAME = combo_Worker.Text;
        }
        private void DayDate_onValueChanged(object sender, EventArgs e)
        {

        }

        private void Res_Time1_EditValueChanged(object sender, EventArgs e)
        {
            get_resTime(Convert.ToInt32(combo_Worker.SelectedValue), (Res_Time.SelectedText));
        }

        private void Res_Time_EditValueChanged(object sender, EventArgs e)
        {
            get_resTime(Convert.ToInt32(combo_Worker.SelectedValue), (Res_Time.SelectedText));
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmManagement FR = new frmManagement();
            FR.ShowDialog();
        }
    }
}

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
    public partial class showGrid : Form
    {
        public int i;
        public string  y,d;
        private static showGrid frm;
        TransationModule TR = new TransationModule();
        static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static showGrid getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new showGrid();
                    frm.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return frm;
            }
        }
        void datagrid() // using stored proucder to get data from table user 
        {
            CONTROLS.BusneisLayer BL = new CONTROLS.BusneisLayer();
            DataTable DT = new DataTable();
            DT = BL.getemployee_dataGrid();
            GRID_Employee.DataSource = DT;
        }

        public showGrid()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;          
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();         
            frm.btn_save.Enabled = true;
            frm.ShowDialog(this);
            datagrid();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف بيانات الموظف المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db_model db = new db_model();
                TBLempoyee ac = (from c in db.TBLempoyees where c.ID == i select c).FirstOrDefault();
                db.TBLempoyees.Where(a => a.ID == i).Select(s => s).FirstOrDefault();
                db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;

                db.SaveChanges();
                MessageBox.Show("تم حذف بيانات الموظف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datagrid();
                string SQL = ": تم خذف موظف بإسم  " + y;
                TR.EnterLog(SQL);
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmployee fr = new frmEmployee();
                fr.btn_save.Enabled = false;
                fr.grpEmployee.Enabled = true;
                fr.EmpID = i;
                fr.txtname.Text = y;
                fr.txtadress.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("العنوان"));
                fr.txtphone.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("رقم الهاتف"));
                fr.txtsalary.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("الراتب"));
                fr.txt_type.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("نوع الوظيفة"));
                fr.txtnote.Text = Convert.ToString(gridView2.GetFocusedRowCellValue("ملاحظة"));
                d = Convert.ToString(gridView2.GetFocusedRowCellValue("تاريخ التعيين"));
                fr.date_time.Value = Convert.ToDateTime(d);

                fr.lbl_text.Text = " تعديل بيانات الموظف :" + " " + Convert.ToString(gridView2.GetFocusedRowCellValue("إسم الموظف"));
                fr.btn_save.Enabled = false;
                //fr.state = "EDIT";
                fr.ShowDialog(this);
                datagrid();
            }
            catch
            {
                return;
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
       
            Close();
        }

        private void showGrid_Load(object sender, EventArgs e)
        {
           
            datagrid();
        }

        private void GRID_CUSTOMER_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt16(gridView2.GetFocusedRowCellValue("رقم الموظف"));
            y = Convert.ToString(gridView2.GetFocusedRowCellValue("إسم الموظف"));

          //  MessageBox.Show("" + i, y);

        }
    }
}

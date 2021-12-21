using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamarPro.CONTROLS;
using System.Data.SqlClient;
using SamarPro.Views;
namespace SamarPro
{
    class TransationModule
    {
        DataAccessLayer DAL = new DataAccessLayer();
        SqlCommand cmd, cmd1;
        SqlDataReader red;
        // this Function For Save Log Douring Transaction Excute
        public void EnterLog(string Function)
        {
            string   EMPLOYEE = Program.Casheir_Name;
            DateTime Date_Entery =Convert.ToDateTime(DateTime.Now.ToShortDateString());
            db_model db = new db_model();
            Logs ac = new Logs
            {
                EmpName = EMPLOYEE,
                Process = Function,                
                Dtime = Date_Entery
            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }

        // this Function To Save Bouns For Employee
        public void CalculateBouns_Save(int EMPID,int RESID,string INFO,double Cash)
        {
            DateTime Date_Entery = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            db_model db = new db_model();
            Bonus ac = new Bonus
            {
                EM_ID = EMPID,
                RES_ID = RESID,
                Note = INFO,
                Money = Cash,
                DayDate = Date_Entery
            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            EnterLog(":  تم إضافة علاوة للموظف رقم " + EMPID);
        }

        // this Function To Edite Bouns For Employee By Reservation ID
        public void CalculateBouns_Edit(int B_ID,int EMPID, int RESID, string INFO, double Cash)
        {
            DateTime Date_Entery = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            db_model db = new db_model();
            Bonus ac = new Bonus
            {
                ID = B_ID,
                EM_ID = EMPID,
                RES_ID = RESID,
                Note = INFO,
                Money = Cash,
                DayDate = Date_Entery
            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        // this Function To Delete Bouns For Employee By Reservation ID
        public void CalculateBouns_Delete(int B_ID, string Name)
        {
            db_model db = new db_model();
            Bonus ac = (from c in db.Bonus where c.ID == B_ID select c).FirstOrDefault();
            db.Bonus.Where(a => a.ID == B_ID).Select(s => s).FirstOrDefault();
            db.Entry(ac).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            EnterLog(": تم حذف علاوة للموظف " + Name);
        }

        // this Function To Save Adversary For Employee
        public void CalculateAdversary(int EMPID, string INFO, double Cash)
        {
            DateTime Date_Entery = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            db_model db = new db_model();
            Adversary ac = new Adversary
            {
                EM_ID = EMPID,
                Note = INFO,
                Money = Cash,
                DayDate = Date_Entery
            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
      
        // this Function For Save Frist Quantity for products
        public void Add_Quantity(int Bar,int Quan)
        {
            db_model db = new db_model();
            Stores ac = new Stores
            {
             Bar_Code = Bar,
             Frist_Quantity = Quan
            };
            db.Entry(ac).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }

        // this Function For Minmaize  Quantity based by uses products
        public void Min_Quantity(int Ser_ID)
        {          
            using (var context = new db_model())
            {
                // using linq to query user data
                var subject = (from x in context.Services
                               join s in context.Products
                               on x.PRD_ID equals s.ID
                               where x.ID == Ser_ID                                 
                               select new { Used = s.Uses, Prd_Id = x.PRD_ID });
                int Used = subject.SingleOrDefault().Used;
                int PRD_ID = subject.SingleOrDefault().Prd_Id;

                DAL.open();
                cmd = new SqlCommand("select count(Code) as count from Reservations where SERTYPE ='" + Ser_ID + "'", DAL.Sqlconnection);
                red = cmd.ExecuteReader();
                red.Read();

                string num = red["count"].ToString();
                red.Close();
                DAL.close();

                int T = Convert.ToInt32(num);
                int mms = T % Used;

                if (T < Used)
                {
                    return;
                }
                if (mms == 0)
                {
                    DAL.open();
                    cmd1 = new SqlCommand("update Products set Quntity = Quntity - 1 where ID ='" + PRD_ID + "'", DAL.Sqlconnection);
                    cmd1.ExecuteNonQuery();
                    return;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Count = " + T.ToString(),mms.ToString());
                }
            }
           
        }

        Message_Notifi Msg = new Message_Notifi();
        public void Show_Message(string Title)
        {
            Msg.lbl_notification.Text = Title;
            Msg.ShowDialog();
        }
    }
}

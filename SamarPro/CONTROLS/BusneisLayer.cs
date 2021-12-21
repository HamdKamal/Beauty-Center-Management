using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamarPro.CONTROLS
{
    
    class BusneisLayer
    {
        DataAccessLayer DAL = new DataAccessLayer();
        // login function 
        public DataTable log_user(string user_type, string user_name, string user_pass)
        {
           
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@user_type", SqlDbType.NVarChar, 30);
            param[0].Value = user_type;

            param[1] = new SqlParameter("@user_name", SqlDbType.NVarChar, 30);
            param[1].Value = user_name;

            param[2] = new SqlParameter("@user_pass", SqlDbType.NVarChar, 30);
            param[2].Value = user_pass;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("log_user", param);
            DAL.close();
            return Dt;
        }
        // get MY_Reservation id 
        public DataTable GETUser_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GETUser_ID", param);
            DAL.close();
            return Dt;
        }
        // get COMPLIMNTE id 
        public DataTable get_complimnteID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_complimnteID", param);
            DAL.close();
            return Dt;
        }

        // get user id 
        public DataTable Get_My_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("Get_My_ID", param);
            DAL.close();
            return Dt;
        }
        // get bill_id
        public DataTable get_bill_id()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_bill_id", param);
            DAL.close();
            return Dt;
        }
        // GET EMPLOYEE ID 
        public DataTable GETEmployee_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GETEmployee_ID", param);
            DAL.close();
            return Dt;
        }

        // GET OFFERE ID 
        public DataTable Get_Offer_ID()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("Get_Offer_ID", param);
            DAL.close();
            return Dt;
        }
        //get_name_Employee  
        public DataTable get_name_Employee(string U_Name)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@U_Name", SqlDbType.NVarChar,35);
            param[0].Value = U_Name;
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_name_Employee", param);
            DAL.close();
            return Dt;
        }

        //get_Service money  
        public DataTable get_ser_money(int SER_ID)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@SER_ID", SqlDbType.Int);
            param[0].Value = SER_ID;
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_ser_money", param);
            DAL.close();
            return Dt;
        }
        // employeeDataGrid
        public DataTable getemployee_dataGrid()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("getemployee_dataGrid", param);
            DAL.close();
            return Dt;
        }

        // get user DATA 
        public DataTable getemployee_data()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("getemployee_data", param);
            DAL.close();
            return Dt;
        }

        // get DATA for combobox 
        public DataTable get_username()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_username", param);
            DAL.close();
            return Dt;
        }

        // get name for product 
        public DataTable getProduct_Name()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("getProduct_Name", param);
            DAL.close();
            return Dt;

        }
        // get name for service 
        public DataTable getServise_Name()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("getServise_Name", param);
            DAL.close();
            return Dt;

        }
        public DataTable get_NAME()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_NAME", param);
            DAL.close();
            return Dt;
        }
        // get supgategory data
        public DataTable get_supGate_data()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_supGate_data", param);
            DAL.close();
            return Dt;
        }
        // get Maingategory data
        public DataTable get_MainGate_data()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_MainGate_data", param);
            DAL.close();
            return Dt;
        }
        // get DATA for Gategory combobox 
        public DataTable get_gate_name()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_gate_name", param);
            DAL.close();
            return Dt;
        }
        // get SERVICE data
        public DataTable SELECT_SERVICE()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("SELECT_SERVICE", param);
            DAL.close();
            return Dt;
        }
        // get Supplaier data
        public DataTable SELECT_Supplaier()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("SELECT_Supplaier", param);
            DAL.close();
            return Dt;
        }

        // get supgate data
        public DataTable get_subgate()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_subgate", param);
            DAL.close();
            return Dt;
        }
        // get Rent data
        public DataTable getRent_Name()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("getRent_Name", param);
            DAL.close();
            return Dt;
        }
        // get service_name data
        public DataTable SELECT_Service_Data()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("SELECT_Service_Data", param);
            DAL.close();
            return Dt;
        }

        // get service_name sgow
        public DataTable get_service_show()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_service_show", param);
            DAL.close();
            return Dt;
        }
        // get Product_name sgow
        public DataTable get_prd_show()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_prd_show", param);
            DAL.close();
            return Dt;
        }
        // Logs DataGrid
        public DataTable Get_All_Logs()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("Get_All_Logs", param);
            DAL.close();
            return Dt;
        }
        // DELETE LOGS
        public void DELETE_LOGS()
        {    
            DAL.open();
            SqlParameter[] parm = new SqlParameter[0];
            DAL.ExecuteCommand("DELETE_LOGS", parm);
            DAL.close();
        }

        // Find Logs data
        public DataTable Find_Logs(string E_Name,DateTime S_Date,DateTime E_Date)
        {
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@E_Name", SqlDbType.NVarChar, 50);
            param[0].Value = E_Name;

            param[1] = new SqlParameter("@S_Date", SqlDbType.DateTime);
            param[1].Value = S_Date;

            param[2] = new SqlParameter("@E_Date", SqlDbType.DateTime);
            param[2].Value = E_Date;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("Find_Logs", param);
            DAL.close();
            return Dt;
        }


        // Find Attendance ID
        public DataTable Get_Attendance(string crreturon, int E_ID)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@crreturon", SqlDbType.VarChar,100);
            param[0].Value = crreturon;

            param[1] = new SqlParameter("@E_ID", SqlDbType.Int);
            param[1].Value = E_ID;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("Get_Attendance", param);
            DAL.close();
            return Dt;
        }
        // get res_time
        public DataTable get_res_time()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_res_time", param);
            DAL.close();
            return Dt;
        }
        // Res_NotDataGrid
        public DataTable GET_NOTIFY(int R_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@R_id", SqlDbType.Int);
            param[0].Value = R_id;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_NOTIFY", param);
            DAL.close();
            return Dt;
        }
        // Res_RES_PosDataGrid
        public DataTable GET_ResourcePrdData(int R_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@R_id", SqlDbType.Int);
            param[0].Value = R_id;

            DataTable Dt = new DataTable();
            Dt = DAL.selectData("GET_ResourcePrdData", param);
            DAL.close();
            return Dt;
        }
        // get get_Resourcebill_id
        public DataTable get_Resourcebill_id()
        {
            SqlParameter[] param = new SqlParameter[0];
            DataTable Dt = new DataTable();
            Dt = DAL.selectData("get_Resourcebill_id", param);
            DAL.close();
            return Dt;
        }
    }
}


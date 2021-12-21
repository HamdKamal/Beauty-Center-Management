using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamarPro.CONTROLS
{
    class DataAccessLayer
    {
        //private SqlConnection sqlconnection;

        public SqlConnection Sqlconnection;

        //constructor inisialize connection object 
        public DataAccessLayer()
        {
            // connected bettwin pro & server using setting in application properties

            Sqlconnection = new SqlConnection(@"data source =MOK-95\SQLEXPRESS;initial catalog=SamarPro.db_model;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        }

        // method to open connection
        public void open()
        {
            if (Sqlconnection.State != ConnectionState.Open)
            {
                Sqlconnection.Open();
            }
        }

        // method to close  connection
        public void close()
        {
            if (Sqlconnection.State != ConnectionState.Closed)
            {
                Sqlconnection.Close();
            }
        }

        // method to read data from database "select data"
        public DataTable selectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = Sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // method to insert ,update and delete data form database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = Sqlconnection;
            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}

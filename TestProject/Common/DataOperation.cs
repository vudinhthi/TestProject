using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject.Common
{
    class DataOperation
    {
        static SqlConnection conn;
        static SqlCommand cmd = new SqlCommand();
        static string conStr = @"Data Source=FVN-PC-IT-09\SQLEXPRESS;Initial Catalog=Northwind;Persist Security Info=True;User ID=sa;Password=12345678;Connect Timeout=30";
        
        public static SqlConnection Getconnection()
        {
            SqlConnection con = new SqlConnection(conStr);
            return con;
        }
        
        public static void Connect()
        {
            try 
            {                
                if (Getconnection().State == ConnectionState.Closed)
                    Getconnection().Open();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Disconnect()
        {
            try
            {
                if (Getconnection().State == ConnectionState.Open)
                    Getconnection().Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string ExcuteScalar(string strQuery, CommandType cmdtype, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            string efftectRecord = "";
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = strQuery;
            sqlcmd.Connection = conn;
            sqlcmd.CommandType = cmdtype;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.SqlValue = values[i];
                sqlcmd.Parameters.Add(sqlpara);
            }
            try
            {
                efftectRecord = sqlcmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return efftectRecord;
        }
    }
}

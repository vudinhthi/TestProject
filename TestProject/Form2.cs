using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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

namespace TestProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string GetConnectionString()
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["TestProject.Properties.Settings.NorthwindConnectionString"].ConnectionString;
            return connection;
        }

        private void LoadDataGrid()
        {
            DataSet ds = new DataSet();
            String connStr = GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                SqlDataAdapter SqlDaProduct = new SqlDataAdapter("SP_GETPRODUCTS", conn);
                SqlDaProduct.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDaProduct.Fill(ds, "Products");

                //Binding Master table to gridControl
                gridControl1.DataSource = ds.Tables["Products"];
                gridControl1.ForceInitialize();

                //Set the columns of master GridView's columns to AutoResize 
                gridView1.OptionsView.ColumnAutoWidth = true;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            conn.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

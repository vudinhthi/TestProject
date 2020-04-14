using DevExpress.Data;
using DevExpress.Data.Extensions;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
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
        public static string userName;
        public static string userPassword;

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

        private void button2_Click(object sender, EventArgs e)
        {
            
            LoginUserControl myControl = new LoginUserControl();            

            if (DevExpress.XtraEditors.XtraDialog.Show(myControl, "Sign in", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (myControl.Controls.Find("teLogin",true)[0].ToString() == "")
                {
                    MessageBox.Show("Enter username");
                }
                else
                {
                    MessageBox.Show("You pressed Ok");
                }                
            }
            else
            {
                MessageBox.Show("You pressed Cancel");
            }
        }
    }

    public class LoginUserControl : XtraUserControl
    {
        public LoginUserControl()
        {            
            LayoutControl lc = new LayoutControl();
            lc.Dock = DockStyle.Fill;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Pumpkin");

            TextEdit teLogin = new TextEdit();
            TextEdit tePassword = new TextEdit();
            tePassword.Properties.UseSystemPasswordChar = true;
            CheckEdit ceKeep = new CheckEdit() { Text = "Keep me signed in" };            

            SeparatorControl separatorControl = new SeparatorControl();
            lc.AddItem(String.Empty, teLogin).TextVisible = false;
            lc.AddItem(String.Empty, tePassword).TextVisible = false;
            lc.AddItem(String.Empty, ceKeep);            
            
            this.Controls.Add(lc);
            this.Height = 100;
            this.Dock = DockStyle.Top;
        }        
    }
}

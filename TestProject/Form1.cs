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
using System.Configuration;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
<<<<<<< HEAD
using System.Net.Sockets;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using DevExpress.XtraEditors;
using System.Diagnostics;
=======
using DevExpress.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraEditors;
using DevExpress.Export;
using DevExpress.Utils;
using System.IO;
using System.Diagnostics;
>>>>>>> c00eb78dc2e0285977ef1ff277a8908a45ae1786
namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            LoadComboxCategories();
            LoadComboBoxProduct();
            LoadQRCodeControl();
            LoadDataGrid();
        }

        public static string GetConnectionString()
        {
            string connection = System.Configuration.ConfigurationManager.ConnectionStrings["TestProject.Properties.Settings.NorthwindConnectionString"].ConnectionString;
            return connection;
        }

        private void LoadQRCodeControl()
        {
            barCodeControl1.Parent = this;
            barCodeControl1.Size = new System.Drawing.Size(150, 150);
            barCodeControl1.AutoModule = true;
            barCodeControl1.Text = "";
            QRCodeGenerator symb = new QRCodeGenerator();
            barCodeControl1.Symbology = symb;

            // Adjust the QR barcode's specific properties. 
            symb.CompactionMode = QRCodeCompactionMode.Byte; //Set this Mode to accept any charaters
            symb.ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.L;
            symb.Version = QRCodeVersion.Version1;
        }

        private void LoadComboBoxProduct()
        {
            DataSet ds = new DataSet();
            String connStr = GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("SP_GETPRODUCTS", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }                

                comboBox1.DataSource = ds.Tables[0];
                comboBox1.DisplayMember = "ProductName";
                comboBox1.ValueMember = "ProductId";

                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;                

                lookUpEdit1.Properties.DataSource= ds.Tables[0];
                lookUpEdit1.Properties.DisplayMember = "ProductName";
                lookUpEdit1.Properties.ValueMember = "ProductID";

                lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("ProductID", "ProductID", 20));
                lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("ProductName", "ProductName", 80));
                lookUpEdit1.Properties.Columns.Add(new LookUpColumnInfo("CategoryName", "CategoryName", 20));
                //enable text editing 
                lookUpEdit1.Properties.TextEditStyle = TextEditStyles.Standard;
                lookUpEdit1.CascadingOwner = lookUpEdit2;
                lookUpEdit1.Properties.CascadingMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            conn.Dispose();
        }
        
        private void LoadComboxCategories()
        {
            DataSet ds = new DataSet();
            String connStr = GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                using (SqlDataAdapter SqlDa = new SqlDataAdapter("SP_GETCATEGORIES", conn))
                {
                    SqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    SqlDa.Fill(ds);
                }

                comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                lookUpEdit2.Properties.DataSource = ds.Tables[0];
                lookUpEdit2.Properties.DisplayMember = "CategoryName";
                lookUpEdit2.Properties.ValueMember = "CategoryID";
                lookUpEdit2.Properties.KeyMember = "CategoryID";

                lookUpEdit2.Properties.Columns.Add(new LookUpColumnInfo("CategoryID", "CategoryID", 20));
                lookUpEdit2.Properties.Columns.Add(new LookUpColumnInfo("CategoryName", "CategoryName", 80));
                //enable text editing 
                lookUpEdit2.Properties.TextEditStyle = TextEditStyles.Standard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            conn.Dispose();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (lookUpEdit1.EditValue != null)
            {
                string qrCode =  lookUpEdit2.Text.ToString() + "|" + lookUpEdit1.Text.ToString();
                textBox1.Text = qrCode;
                barCodeControl1.Text = textBox1.Text.ToString();                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lookUpEdit1.EditValue = int.Parse(textBox1.Text.ToString());
            //barCodeControl1.Text = textBox1.Text;
            //Form3 form3 = new Form3();
            //form3.Show();

            //string passDecrypt = null;
            //Cls_EnDeCrypt cls_EnDe = new Cls_EnDeCrypt();
            //passDecrypt = cls_EnDe.Encrypt(textBox1.Text, true);
            //textEdit1.Text = passDecrypt;
            ExportExcel("");
        }

        private bool ExportExcel(string filename)
        {
            try
            {
                var dialog = new SaveFileDialog();
                dialog.Title = @"Export file to Excel";
                dialog.FileName = filename;
                dialog.Filter = @"Microsoft Excel|*.xlsx";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    gridView1.RefreshData();
                    gridView1.OptionsPrint.ShowPrintExportProgress = true;
                    gridView1.OptionsPrint.AllowCancelPrintExport = true;                    

                    XlsxExportOptions options = new XlsxExportOptions();
                    options.TextExportMode = TextExportMode.Text;
                    options.ExportMode = XlsxExportMode.SingleFile;

                    ExportSettings.DefaultExportType = ExportType.Default;
                    gridView1.ExportToXlsx(dialog.FileName, options);
                    XtraMessageBox.Show("Successed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, DefaultBoolean.True);
                    
                    if (File.Exists(dialog.FileName))
                    {
                        if (XtraMessageBox.Show("Do you want open file? ", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Process.Start(dialog.FileName);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Error: " + e, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            lookUpEdit1.EditValue = null;
        }

        private void ShowGridViewColumns()
        {
            
        }

        private void LoadDataGrid()
        {
            DataSet ds = new DataSet();
            String connStr = GetConnectionString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {
                //Binding data for 2 gridView and attach to gridControl
                SqlDataAdapter SqlDaCategories = new SqlDataAdapter("SP_GETCATEGORIES", conn);
                SqlDataAdapter SqlDaProduct = new SqlDataAdapter("SP_GETPRODUCTS", conn);
                SqlDaCategories.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDaProduct.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlDaCategories.Fill(ds,"Categories");
                SqlDaProduct.Fill(ds, "Products");

                //Set up a master-detail relationship between the DataTables 
                DataColumn keyColumn = ds.Tables["Categories"].Columns["CategoryID"];
                DataColumn foreignKeyColumn = ds.Tables["Products"].Columns["CategoryID"];
                ds.Relations.Add("CategoriesProducts", keyColumn, foreignKeyColumn);
                
                //Binding Master table to gridControl
                gridControl1.DataSource= ds.Tables["Categories"];
                gridControl1.ForceInitialize();

                gridView1.Columns["CategoryID"].VisibleIndex = -1;                

                //Set the columns of master GridView's columns to AutoResize 
                gridView1.OptionsView.ColumnAutoWidth = true;

                //Bind data to GridView2 and attachment to the GridView1 as a Detail
                GridView gridView2 = new GridView(gridControl1);
                gridControl1.LevelTree.Nodes.Add("CategoriesProducts", gridView2);

                //Set caption for detail GridView
                gridView2.ViewCaption = "Products";

                //Generate all columns of datatable resource of detail GridView
                gridView2.PopulateColumns(ds.Tables["Products"]);

                //Hide unsual columns of detail GridView
                gridView2.Columns["CategoryID"].VisibleIndex=-1;
                gridView2.Columns["CategoryName"].VisibleIndex = -1;

                //Set column's width of detail GridView
                gridView2.Columns["ProductID"].Width = 40;
                gridView2.Columns["ProductName"].Width = 150;

                //Set editable of two GridViews to not allows
                gridView1.MasterRowExpanded += gridView1_MasterRowExpanded;
                gridView1.OptionsBehavior.Editable = gridView2.OptionsBehavior.Editable = false;

                //gridView1.Columns["CategoryID"].Width = 40;
                //gridView1.Columns["ProductName"].Width = 120;

                //Assign a CardView to the relationship 
                //CardView cardView1 = new CardView(gridControl1);
                //gridControl1.LevelTree.Nodes.Add("CategoriesProducts", cardView1);

                //Specify text to be displayed within detail tabs. 
                //cardView1.ViewCaption = "Category Products";

                //Create columns for the detail pattern View 
                //cardView1.PopulateColumns(ds.Tables["Products"]);
                //Hide the CategoryID column for the detail View 
                //cardView1.Columns["CategoryID"].VisibleIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            conn.Dispose();
        }

        private void gridView1_MasterRowExpanded(object sender, CustomMasterRowEventArgs e)
        {
            GridView master = sender as GridView;
            GridView detail = master.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            detail.Click += new EventHandler(detail_Click);
        }

        private void detail_Click(object sender, EventArgs e)
        {
            GridView gridView = sender as GridView;
            var value = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.FocusedColumn);
            MessageBox.Show("Cell value: " + value.ToString(), "Message");
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            GridView gridView = sender as GridView;
            var value = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.FocusedColumn);
            var value1 = gridView.GetRowCellValue(gridView.FocusedRowHandle, gridView.Columns["CategoryID"]);
            lookUpEdit2.EditValue = value1;
            //MessageBox.Show("Cell value: " + value1.ToString(), "Message");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Cls_EnDeCrypt cls_EnDe = new Cls_EnDeCrypt();
            //textEdit2.Text = cls_EnDe.Decrypt(textEdit1.Text, true);

            var client = new TcpClient("localhost", 123);
            // Translate the passed message into ASCII and store it as a Byte array.
            //Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

            // Get a client stream for reading and writing. 
            NetworkStream stream = client.GetStream();

            // Send the message to the connected TcpServer. 
            //stream.Write(data, 0, data.Length); //(**This is to send data using the byte method**) 

            // Buffer to store the response bytes.
            //data = new Byte[256];

            // String to store the response ASCII representation.
            String responseData = String.Empty;

            // Read the first batch of the TcpServer response bytes.
            //Int32 bytes = stream.Read(data, 0, data.Length); //(**This receives the data using the byte method**)

            //responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes); //(**This converts it to string**)

            string path = @"D:\Text\test.txt";
            File.AppendAllText(path, "Text from TCP IP"); //(Write string to file)

            stream.Close();
            client.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowGridViewColumns();
        }
    }
}

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject.Controllers
{
    class User
    {
        public static string GetUser(string _userName, string _userPassword)
        {
            try 
            {
                Models.User login = new Models.User(_userName, _userPassword);
                return login.CheckUser();
            }
            catch (Exception ex)
            {                
                XtraMessageBox.Show("Error: " + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }
    }
}

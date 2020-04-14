using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;

namespace TestProject.Models
{
    class User
    {
        protected string UserName { get; set; }
        protected string UserPassword { get; set; }
        protected int Status { get; set; }

        public User(string _userName, string _userPassword)
        {
            this.UserName = _userName;
            this.UserPassword = _userPassword;
        }

        public string CheckUser()
        {
            string str = "";
            string[] param = new string[2] {"@userName","@userPassword" };
            object[] value = new object[2] { UserName, UserPassword };
            str = Common.DataOperation.ExcuteScalar("sp_getUser", CommandType.StoredProcedure, param, value);
            return str;
        }
    }
}

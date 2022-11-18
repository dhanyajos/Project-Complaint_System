using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ComplaintProject.BAL
{

    public class RegBAL
    {
        DAL.RegDAL objdeptdl = new DAL.RegDAL();
        private string _user_name;
        private string _user_id;
        private string _user_email;
        private string _user_phone;
        private string _user_gender;

        private object _user_lid;
        private string _username;
        private string _password;
        private string _usertype;


        public string user_name
        {
            get
            {
                return _user_name;
            }
            set
            {
                _user_name = value;
            }
        }

        public string user_id
        {
            get
            {
                return _user_id;
            }
            set
            {
                _user_id = value;
            }
        }
        public string user_email
        {
            get
            {
                return _user_email;
            }
            set
            {
                _user_email = value;
            }
        }
        public string user_phone
        {
            get
            {
                return _user_phone;
            }
            set
            {
                _user_phone = value;
            }
        }


        public string user_gender
        {
            get
            {
                return _user_gender;
            }
            set
            {
                _user_gender = value;
            }
        }

        public object lid
        {
            get
            {
                return _user_lid;
            }
            set
            {
                _user_lid = value;
            }
        }
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public string usertype
        {
            get
            {
                return _usertype;
            }
            set
            {
                _usertype = value;
            }
        }

        public DataTable Checkdupicates()
        {
            return objdeptdl.check_duplicates(this);

        }
        public object user_login_insert()
        {
            return objdeptdl.userlogin(this);
        }
        public int user_reg()
        {
            return objdeptdl.user_registration(this);
        }

        public DataTable view_unconfirmedusers()
        {
            return objdeptdl.View_unconfirmedusers(this);
        }


        public int confirmuser()
        {
            return objdeptdl.Confirm_user(this);
        }


        public DataTable verifieduserlist()
        {
            return objdeptdl.view_verified_userslist(this);
        }


        public DataTable userlogin()
        {
            return objdeptdl.User_login(this);
        }

        

    }
}
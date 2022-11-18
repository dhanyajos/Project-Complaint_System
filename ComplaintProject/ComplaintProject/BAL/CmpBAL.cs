using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ComplaintProject.BAL
{
    
    public class CmpBAL
    {
        DAL.CmpDAL objdptdl = new DAL.CmpDAL();

        public int _productid;
        public int _user_id;
        public string _product;
        private string _cmpmsg;
        private string _cmpsts;
        private string _cmpdate;
        public string _cmpid;
        private string _user_phone;
        public int productid
        {
            get
            {
                return _productid;
            }
            set
            {
                _productid = value;
            }
        }
        public string product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
            }
        }
        public int user_id
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
        public string cmpmsg
        {
            get
            {
                return _cmpmsg;
            }
            set
            {
                _cmpmsg = value;
            }
        }

        public string cmpsts
        {
            get
            {
                return _cmpsts;
            }
            set
            {
                _cmpsts = value;
            }
        }

        public string cmpdate
        {
            get
            {
                return _cmpdate;
            }
            set
            {
                _cmpdate = value;
            }
        }

        public string cmpid
        {
            get
            {
                return _cmpid;
            }
            set
            {
                _cmpid = value;
            }
        }
        public DataTable ProductValues()
        {

            return objdptdl.Product_list();

        }


        public int complaint_reg()
        {
            return objdptdl.complaintReg(this);
        }


        public DataTable viewComplaints()
        {
            return objdptdl.view_complaints(this);
        }


        public DataTable userViewComplaint()
        {
            return objdptdl.user_view_complaints(this);
        }


        public int updateStatus()
        {
            return objdptdl.Update_Status(this);
        }

      
    }
}
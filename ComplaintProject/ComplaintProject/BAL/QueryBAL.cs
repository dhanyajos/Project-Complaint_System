using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ComplaintProject.BAL
{
    public class QueryBAL
    {
        DAL.QueryDAL objdptdl = new DAL.QueryDAL();

        public int _productid;
        public int _user_id;
        private string _querymsg;
        public string _qryreply;
        public string _qryid;
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

        public string querymsg
        {
            get
            {
                return _querymsg;
            }
            set
            {
                _querymsg = value;
            }
        }

        public string queryreply
        {
            get
            {
                return _qryreply;
            }
            set
            {
                _qryreply = value;
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


        public string queryid
        {
            get
            {
                return _qryid;
            }
            set
            {
                _qryid = value;
            }
        }
        public DataTable ProductValues()
        {

            return objdptdl.Product_list();

        }
        public int query_reg()
        {
            return objdptdl.queryReg(this);
        }
        public DataTable viewQueries()
        {
            return objdptdl.view_query(this);
        }

        public DataTable userViewQueryStatus()
        {
            return objdptdl.user_view_querystatus(this);
        }

        public int giveReply()
        {
            return objdptdl.give_reply(this);
        }
    }
}
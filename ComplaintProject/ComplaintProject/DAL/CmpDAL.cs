using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ComplaintProject.DAL
{
    public class CmpDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public CmpDAL()
        {
            string conn = ConfigurationManager.ConnectionStrings["rose"].ConnectionString;
            con = new SqlConnection(conn);
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
       
        public DataSet ProductValues(int productid)
        {

            string qry = "select  * from Product where productid='" + productid + "'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.ExecuteNonQuery();
            da.Fill(ds);
            return ds;
        }


        public DataTable Product_list()
        {

            string qry = "select  * from Product";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }



        public int complaintReg(BAL.CmpBAL obj)
        {

            string s = "insert into CompReg  values('" + obj.productid + "','" + obj.user_id + "','" + obj.cmpmsg + "','Complaint Received','" + DateTime.Now.ToLongDateString().ToString()+" "+ DateTime.Now.ToLongTimeString().ToString() + "')";

            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }
        public DataTable view_complaints(BAL.CmpBAL obj)
        {

            string qry = "select  c.cmpdate,c.user_id,p.product,u.user_name,u.user_phnno, c.cmpmsg, c.cmpstatus from Product p  INNER JOIN CompReg c  ON p.productid = c.productid INNER JOIN UserReg u ON u.user_id =c.user_id";

            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }



        public int Update_Status(BAL.CmpBAL obj)
        {
            string s = "update CompReg  set cmpstatus='" + obj.cmpsts + "' where user_id=(SELECT user_id FROM UserReg WHERE user_phnno='" + obj.user_phone + "')";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }


        public DataTable user_view_complaints(BAL.CmpBAL obj)
        {
        string qry = "select  c.cmpdate,p.product,u.user_phnno,c.cmpmsg, c.cmpstatus from Product p  INNER JOIN CompReg c  ON p.productid = c.productid INNER JOIN UserReg u ON u.user_id = c.user_id AND c.user_id ='" + obj.user_id + "'";

            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

      
    }
}
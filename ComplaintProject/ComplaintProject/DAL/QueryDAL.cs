using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ComplaintProject.DAL
{
    public class QueryDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public QueryDAL()
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

        public DataTable Product_list()
        {

            string qry = "select  * from Product";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }




        public int queryReg(BAL.QueryBAL obj)
        {

            string s = "insert into Userquery  values('" + obj.productid + "','" + obj.user_id + "','" + obj.querymsg + "','" + obj.queryreply + "')";

            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable view_query(BAL.QueryBAL obj)
        {
            string qry= "SELECT c.queryid,p.product,u.user_name,u.user_phnno, c.querymsg, c.reply from Product p  INNER JOIN Userquery c  ON p.productid = c.productid INNER JOIN UserReg u ON u.user_id = c.user_id order by queryid desc";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public int give_reply(BAL.QueryBAL obj)
        {
            string s = "update Userquery  set reply='" + obj.queryreply + "' where queryid='" + obj.queryid + "'";
          
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

        public DataTable user_view_querystatus(BAL.QueryBAL obj)
        {
           string qry = "select p.product,u.user_phnno, c.querymsg, c.reply from Product p  INNER JOIN Userquery c  ON p.productid = c.productid INNER JOIN UserReg u ON u.user_id = c.user_id AND c.user_id ='" + obj.user_id + "'";

            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
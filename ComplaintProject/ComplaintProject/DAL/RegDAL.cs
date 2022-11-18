using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ComplaintProject.DAL
{
    public class RegDAL
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public RegDAL()
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

       public DataTable check_duplicates(BAL.RegBAL obj)
        {
            string s = "Select * from UserReg where user_phnno='" + obj.user_phone + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public object userlogin(BAL.RegBAL obj)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login values('" + obj.username + "','" + obj.password + "','user','Not confirmed');select @@IDENTITY";
            object id = cmd.ExecuteScalar();

            return id;
         }

        public int user_registration(BAL.RegBAL obj)
        {


            string s = "insert into UserReg values('" + obj.user_name + "','" + obj.user_email + "','" + obj.user_phone + "','" + obj.user_gender + "','" + obj.lid + "')";

            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

       
        public DataTable User_login(BAL.RegBAL obj)
        {
            string s = "select s.*,l.username,l.password,l.usertype,l.status from UserReg s inner join login l on s.lid=l.lid  WHERE username='" + obj.username + "' AND password='" + obj.password + "'";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }



        public DataTable View_unconfirmedusers(BAL.RegBAL obj)
        {
            string qry = "select  s.user_name,s.user_email,s.user_phnno,s.gender from UserReg s inner join login l on s.lid=l.lid where l.status='not confirmed' and usertype='user'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable view_verified_userslist(BAL.RegBAL obj)
        {
            string qry = "select  s.user_name,s.user_email,s.user_phnno,s.gender from UserReg s inner join login l on s.lid=l.lid where l.status='confirmed' and usertype='user'";
            SqlCommand cmd = new SqlCommand(qry, Getcon());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int Confirm_user(BAL.RegBAL obj)
        {

            string s = "update login set status='confirmed' where lid=(SELECT lid FROM UserReg WHERE user_phnno='" +obj.user_phone + "')";
            SqlCommand cmd = new SqlCommand(s, Getcon());
            return cmd.ExecuteNonQuery();
        }

    }
}
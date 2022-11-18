using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintProject.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        BAL.RegBAL objdptbl = new BAL.RegBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdptbl.username = TextBox1.Text;
            objdptbl.password = TextBox2.Text;
            DataTable dt = objdptbl.userlogin();

            if (dt.Rows.Count > 0)
            {


                if (dt.Rows[0]["usertype"].ToString() == "admin")
                {
                    Response.Redirect("../admin/adminhome.aspx");
                }
                else if (dt.Rows[0]["usertype"].ToString() == "user")
                {
                    if (dt.Rows[0]["status"].ToString() == "confirmed")
                    {
                        Session["UserName"] = dt.Rows[0]["username"].ToString();
                        Session["user_id"] = dt.Rows[0]["user_id"].ToString();
                        Response.Redirect("../User/userhome.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert(' User not verified');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials');</script>");
                }
                

            }
        }
            
    }

}

    

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintProject.Guest
{
    public partial class RegUser : System.Web.UI.Page
    {
        BAL.RegBAL objdptbl = new BAL.RegBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdptbl.user_phone = TextBox3.Text;
            DataTable dt = objdptbl.Checkdupicates();
            if (dt.Rows.Count > 0)
            {
                lblmessage.Text = "Phone Number Already Exists";
            }
            else
            {

                objdptbl.user_name = TextBox1.Text;
                objdptbl.user_email = TextBox2.Text;
                objdptbl.user_phone = TextBox3.Text;
                string gender = string.Empty;
                if (RadioButton1.Checked)
                {
                    gender = "Male";
                }
                else if (RadioButton2.Checked)
                {
                    gender = "Female";
                }
                else
                {
                    gender = "Others";
                }
                objdptbl.user_gender = gender;

                objdptbl.username = TextBox4.Text;
                objdptbl.password = TextBox5.Text;
                object ob = objdptbl.user_login_insert();
                objdptbl.lid = ob;
                int j = objdptbl.user_reg();

              
                Response.Write("<script LANGUAGE='JavaScript' >alert('User Registered successfully');document.location='" + ResolveClientUrl("Home.aspx") + "';</script>");

            }
        }
    }
}
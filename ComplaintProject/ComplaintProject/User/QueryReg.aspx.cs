using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintProject.User
{
    public partial class QueryReg : System.Web.UI.Page
    {
        BAL.QueryBAL objdptbl = new BAL.QueryBAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                productid_bind();


            }

        }
        public void productid_bind()
        {
            DataTable prod = objdptbl.ProductValues();
            ddlproduct.DataSource = objdptbl.ProductValues();
            ddlproduct.DataTextField = "product";
            ddlproduct.DataValueField = "productid";
            ddlproduct.DataBind();
            ddlproduct.Items.Insert(0, new ListItem("-- Select --", "0"));
        }



        protected void Button1_Click(object sender, EventArgs e)
        {

            objdptbl.productid = Convert.ToInt32(ddlproduct.SelectedIndex);

            objdptbl.user_id = Convert.ToInt32(Session["user_id"]);
            objdptbl.querymsg = cmpmsg.Text;
            objdptbl.queryreply = null;
            int i = objdptbl.query_reg();
            if (i == 1)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Query Registered successfully');document.location='" + ResolveClientUrl("userhome.aspx") + "';</script>");


            }

        }

    }

}

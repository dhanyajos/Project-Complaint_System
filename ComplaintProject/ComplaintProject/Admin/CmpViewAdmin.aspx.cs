using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintProject.Admin
{
    public partial class CmpViewAdmin : System.Web.UI.Page
    {
        BAL.CmpBAL objdptbl = new BAL.CmpBAL();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objdptbl.viewComplaints();
                GridView1.DataBind();
            }
        }


        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objdptbl.viewComplaints();
            GridView1.DataBind();
        }



        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0];
            objdptbl.cmpid = id.ToString();
            objdptbl.cmpsts = txt.Text;
            int i = objdptbl.updateStatus();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objdptbl.viewComplaints();
            GridView1.DataBind();


        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            GridView1.EditIndex = -1;
            GridView1.DataSource = objdptbl.viewComplaints();
            GridView1.DataBind();
        }


    }
}
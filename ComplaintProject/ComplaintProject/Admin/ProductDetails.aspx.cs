using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintProject.Admin
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        BAL.ProductBAL objdptbl = new BAL.ProductBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = objdptbl.viewProduct();
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            objdptbl.product = TextBox1.Text;
            int i = objdptbl.insertProduct();
            GridView1.DataSource = objdptbl.viewProduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

            objdptbl.productid = id.ToString();

            int i = objdptbl.deleteProduct();

            GridView1.DataSource = objdptbl.viewProduct();
            GridView1.DataBind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = objdptbl.viewProduct();
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txt = new TextBox();
            txt = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
            objdptbl.productid = id.ToString();
            objdptbl.product = txt.Text;
            int i = objdptbl.updateProduct();
            GridView1.EditIndex = -1;
            GridView1.DataSource = objdptbl.viewProduct();
            GridView1.DataBind();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = objdptbl.viewProduct();
            GridView1.DataBind();
        }
    }
}
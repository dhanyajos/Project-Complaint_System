using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintProject.Admin
{
    public partial class ConfirmedUserList : System.Web.UI.Page
    {
        BAL.RegBAL objdeptbl = new BAL.RegBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                GridView1.DataSource = objdeptbl.verifieduserlist();
                GridView1.DataBind();
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComplaintProject.User
{
    public partial class ViewComplaintSts : System.Web.UI.Page
    {
        BAL.CmpBAL objdptbl = new BAL.CmpBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objdptbl.user_id = Convert.ToInt32(Session["user_id"]);
                GridView1.DataSource = objdptbl.userViewComplaint();
                GridView1.DataBind();
            }
        }

  
    }
}
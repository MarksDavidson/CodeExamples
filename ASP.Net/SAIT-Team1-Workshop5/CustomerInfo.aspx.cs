using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //brodie Modified for login Feb 03 2015
        bool log = Convert.ToBoolean(Session["loggedin"]);
        
        if (log == false)
        {
            Response.Redirect("~/Account/Login.aspx");
        }
        else if (log == true && Convert.ToBoolean(Session["new"]) == true)
        {
            ListView1.InsertItemPosition = InsertItemPosition.FirstItem;
            ((TextBox)ListView1.FindControl("Email")).Text = Session["newEmail"].ToString();
            
        }

    }
}
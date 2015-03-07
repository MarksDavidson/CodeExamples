using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public void Page_Load(object sender, EventArgs e)
    {
        
        int custid = Convert.ToInt32(Session["customer"]);
        double total = PackagesDB.getpkgtotal(custid);
        lbltotal.Text = total.ToString("c"); 

        //Brodie Modified Feb 03 2015, added check login
        if (Convert.ToBoolean(Session["loggedin"]) == false)
        {
            Response.Redirect("~/Account/Login.aspx");
        }
    }

}
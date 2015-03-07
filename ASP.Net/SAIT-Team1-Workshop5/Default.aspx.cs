using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Team1_Workshop4_Part2;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // hide the greeting panel
        pnlGreeting.Visible = false;
        //Brodie Modifed to check logged in session variables Feb 03 2015
        if (Session["loggedin"] == null)
        {
            Session["loggedin"] = false;
        }
    }

}
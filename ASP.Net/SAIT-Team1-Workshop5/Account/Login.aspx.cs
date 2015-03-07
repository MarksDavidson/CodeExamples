using Microsoft.AspNet.Membership.OpenAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Team1_Workshop4_Part2;

public partial class Account_Login : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
     //  RegisterHyperLink.NavigateUrl = "Register.aspx";
      // OpenAuthLogin.ReturnUrl = Request.QueryString["CustomerBookings.aspx"];

       var returnUrl = HttpUtility.UrlEncode(Request.QueryString["CustomerBookings.aspx"]);
        if (!String.IsNullOrEmpty(returnUrl))
        {
       // RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
        }
    }
    protected void Login_Click(object sender, EventArgs e)
    {
        //Brodie Added Feb 03 2015
        string user = ((TextBox)Login1.FindControl("UserName")).Text;
        string pass = ((TextBox)Login1.FindControl("Password")).Text;
        if (CustomerDB.Login(user, pass) != null)
        {
            Customer customer = CustomerDB.Login(user, pass);
            Session["loggedin"] = true;

   
                Session["customer"] = customer.CustomerID;
                Response.Redirect("~/CustomerInfo.aspx");

        }
        else
        {
            Session["loggedin"] = false;
            Response.Write("<script>alert('Credentials Entered Incorrectly or do not exist!');</script>");
        }
    }
}
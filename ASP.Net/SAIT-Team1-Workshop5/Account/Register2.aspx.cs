using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Register2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (CustomerDB.GetCustomerByEmail(txtemail.Text) == null)
        {
            Customer newcust = new Customer();

            newcust.CustFirstName = txtfirst.Text;
            newcust.CustLastName = txtlast.Text;
            newcust.CustEmail = txtemail.Text;
            newcust.CustAddress = txtaddress.Text;
            newcust.CustCity = txtcity.Text;
            newcust.CustCountry = txtcountry.Text;
            newcust.CustPostal = txtpostal.Text;
            newcust.CustProv = txtprov.Text;
            newcust.CustHomePhone = txthomephone.Text;
            newcust.CustBusPhone = txtbusphone.Text;
            newcust.CustPassword = txtconpass.Text;

            CustomerDB.AddCustomer(newcust);
            Session["loggedin"] = true;
            Session["customer"] = newcust.CustomerID;


        }
        else
        {
            //lblusernameerror.Text = "Username Already Taken";
        }
        
    }
    protected void btncls_Click(object sender, EventArgs e)
    {
       txtfirst.Text = "";
       txtlast.Text = "";
       txtemail.Text = "";
       txtaddress.Text = "";
       txtcity.Text = "";
       txtcountry.Text = "";
       txtpostal.Text = "";
       txthomephone.Text = "";
       txtbusphone.Text = "";
       txtconpass.Text = "";
    }
}
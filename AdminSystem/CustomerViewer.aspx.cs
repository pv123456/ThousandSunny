using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write(ACustomer.CustId);
        Response.Write(ACustomer.CustUsername);
        Response.Write(ACustomer.CustPassword);
        Response.Write(ACustomer.CustEmail);
        Response.Write(ACustomer.CustDOB);
        Response.Write(ACustomer.Over18);
    }
}
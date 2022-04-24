using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustId = Convert.ToInt32(Session["CustID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        Customer.ThisCustomer.Find(CustId);
        Customer.Delete();
        Response.Redirect("CustomerList.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}
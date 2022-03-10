using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Create a new instance of the clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //Captures the values
        ACustomer.CustUsername = txtCustUsername.Text;
        ACustomer.CustPassword = txtCustPassword.Text;
        ACustomer.CustEmail = txtCustEmail.Text;
        ACustomer.CustDOB = Convert.ToDateTime(txtCustDOB.Text);

        //Stores the customer in the session object
        Session["ACustomer"] = ACustomer;
        //Goes back to the Customer viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}
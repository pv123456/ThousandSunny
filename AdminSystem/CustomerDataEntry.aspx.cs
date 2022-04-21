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
        string CustUsername = txtCustUsername.Text;
        string CustPassword = txtCustPassword.Text;
        string CustEmail = txtCustEmail.Text;
        string CustDOB = txtCustDOB.Text;
        string Error = "";
        Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
        if(Error == "")
        {
            ACustomer.CustUsername = CustUsername;
            ACustomer.CustPassword = CustPassword;
            ACustomer.CustEmail = CustEmail;
            ACustomer.CustDOB = Convert.ToDateTime(CustDOB);
            Session["ACustomer"] = ACustomer;
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustId;
        Boolean Found = false;
        CustId = Convert.ToInt32(txtCustId);
        Found = ACustomer.Find(CustId);
        if(Found == true)
        {
            txtCustUsername.Text = ACustomer.CustUsername;
            txtCustPassword.Text = ACustomer.CustPassword;
            txtCustEmail.Text = ACustomer.CustEmail;
            txtCustDOB.Text = ACustomer.CustDOB.ToString();
            chkOver18.Checked = ACustomer.Over18;

        }
    }
}
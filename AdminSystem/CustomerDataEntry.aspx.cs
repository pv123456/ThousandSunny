﻿using System;
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
        ACustomer.CustId = Convert.ToInt32(txtCustId.Text);
        ACustomer.CustUsername = txtCustUsername.Text;
        ACustomer.CustPassword = txtCustPassword.Text;
        ACustomer.CustEmail = txtCustEmail.Text;
        ACustomer.CustDOB = Convert.ToDateTime(txtCustDOB.Text);
        ACustomer.Over18 = chkOver18.Checked;

        //Stores the customer in the session object
        Session["ACustomer"] = ACustomer;
        //Goes back to the Customer viewer page
        Response.Redirect("CustomerViewer.aspx");
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
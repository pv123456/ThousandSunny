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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create an instance 
        clsSupplier AnSupplier = new clsSupplier();
        
        
        //capture a supplier
        
        string SupplierName = txtSupplierName.Text;
        string SupplierEmail = txtSupplierEmail.Text;
        string SupplierAddress = txtSupplierAddress.Text;
        string StartDateSupplier = txtStartDateSupplier.Text;
        
         string Error = "";
        Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
        if (Error == "")
        {
            //capture a supplier
            AnSupplier.SupplierName = SupplierName;
            AnSupplier.SupplierEmail = SupplierEmail;
            AnSupplier.SupplierAddress = SupplierAddress;
            AnSupplier.StartDateSupplier = Convert.ToDateTime(StartDateSupplier);
            //store Supplier Name in the session object
            Session["AnSupplier"] = AnSupplier;
            //Goes to the viewer page
            Response.Write("SupplierViewer.aspx");

        }
        else 
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        
        Int32 SupplierID;
        Boolean Found = false;

        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        Found = AnSupplier.Find(SupplierID);

        if (Found == true) 
        {
            txtSupplierName.Text = AnSupplier.SupplierName;
            txtSupplierEmail.Text = AnSupplier.SupplierEmail;
            txtSupplierAddress.Text = AnSupplier.SupplierAddress;
            txtStartDateSupplier.Text = AnSupplier.StartDateSupplier.ToString();
            chkSupplierDiscountPrice.Checked = AnSupplier.SupplierDiscountPrice;

        }
    }
}
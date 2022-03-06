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
        AnSupplier.SupplierID = Convert.ToInt32(txtSupplierID.Text);
        AnSupplier.SupplierName = txtSupplierName.Text;
        AnSupplier.SupplierEmail = txtSupplierEmail.Text;
        AnSupplier.SupplierAddress = txtSupplierAddress.Text;
        AnSupplier.StartDateSupplier = Convert.ToDateTime(txtStartDateSupplier.Text);
        AnSupplier.SupplierDiscountPrice = chkSupplierDiscountPrice.Checked;
        
        //store Supplier Name in the session object
        Session["AnSupplier"] = AnSupplier;
        //Goes to the viewer page
        Response.Redirect("SupplierViewer.aspx");
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